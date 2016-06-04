using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MusicRandomizer
{
    public partial class MainForm : Form
    {
        public const byte BYTE_NORMAL = 0xff;
        public const byte BYTE_SPECIAL = 0xfe;
        public const byte BYTE_OPEN = 0x00;
        public const byte BYTE_READ = 0x01;
        public const byte BYTE_CLOSE = 0x02;
        public const byte BYTE_OK = 0x03;
        public const byte BYTE_SETPOS = 0x04;
        public const byte BYTE_STATFILE = 0x05;
        public const byte BYTE_EOF = 0x06;
        public const byte BYTE_GETPOS = 0x07;
        public const byte BYTE_REQUEST = 0x08;
        public const byte BYTE_REQUEST_SLOW = 0x09;
        public const byte BYTE_HANDLE = 0x0A;
        public const byte BYTE_DUMP = 0x0B;
        public const byte BYTE_PING = 0x0C;

        [Flags]
        public enum FSStatFlag : uint
        {
            None = 0,
            unk_14_present = 0x01000000,
            mtime_present = 0x04000000,
            ctime_present = 0x08000000,
            entid_present = 0x10000000,
            directory = 0x80000000,
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct FSStat
        {
            public FSStatFlag flags;
            public uint permission;
            public uint owner;
            public uint group;
            public uint file_size;
            public uint unk_14_nonzero;
            public uint unk_18_zero;
            public uint unk_1c_zero;
            public uint ent_id;
            public uint ctime_u;
            public uint ctime_l;
            public uint mtime_u;
            public uint mtime_l;
            public uint unk_34_zero;
            public uint unk_38_zero;
            public uint unk_3c_zero;
            public uint unk_40_zero;
            public uint unk_44_zero;
            public uint unk_48_zero;
            public uint unk_4c_zero;
            public uint unk_50_zero;
            public uint unk_54_zero;
            public uint unk_58_zero;
            public uint unk_5c_zero;
            public uint unk_60_zero;
        }

        public enum LogType
        {
            Info = 0,
            Error = 1,
            File = 2,
            ReplacedFile = 3,
            RequestedFile = 4,
            TitleID = 5,
            NowPlaying = 6
        }

        public static readonly Random random = new Random();
        public List<MusicFile> musicFiles;
        private List<FileTracker> fileTrackers = new List<FileTracker>();
        private MusicFile playNext = null;
        private PlayMode playMode = PlayMode.Shuffle;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("tracks"))
            {
                Directory.CreateDirectory("tracks");
            }

            if (!Directory.Exists("other_files"))
            {
                Directory.CreateDirectory(Path.Combine("other_files", "vol", "content"));
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<MusicFile>), new XmlRootAttribute("Tracks"));
            if (!File.Exists("Tracks.xml"))
            {
                musicFiles = new List<MusicFile>();
                SaveTrackList();

                lstOutput.Items.Add("Please import your first track.");
            }
            else
            {
                using (FileStream stream = File.OpenRead("Tracks.xml"))
                {
                    musicFiles = (List<MusicFile>)serializer.Deserialize(stream);
                }

                RefreshTrackList(true);
            }

            backgroundWorker.RunWorkerAsync();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        public void RefreshTrackList(Boolean clearTrackers)
        {
            lsvTracks.Items.Clear();

            if (clearTrackers)
            {
                fileTrackers.Clear();

                for (int i = 0; i < 17; i++) // update this if the list of TrackTypes expands
                {
                    fileTrackers.Add(new FileTracker());
                }
            }

            foreach (MusicFile file in musicFiles)
            {
                String types = "";
                foreach (TrackType type in file.types)
                {
                    if (!fileTrackers[(int)type].files.Contains(file))
                    {
                        fileTrackers[(int)type].files.Add(file);
                    }

                    types += type.ToUIString() + ", ";
                }

                types = types.Substring(0, types.Length - 2);
                String name = Path.GetFileName(file.path);
                lsvTracks.Items.Add(new ListViewItem(new String[] { name.Substring(0, name.Length - 6), types }));
            }

            SaveTrackList();
        }

        public void SaveTrackList()
        {
            File.Delete("Tracks.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(List<MusicFile>), new XmlRootAttribute("Tracks"));
            using (FileStream writer = File.OpenWrite("Tracks.xml"))
            {
                serializer.Serialize(writer, musicFiles);
            }
        }

        private void Log(LogType type, String str)
        {
            backgroundWorker.ReportProgress((int) type, str);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                TcpListener listener = new TcpListener(IPAddress.Any, 7332);
                listener.Start();
                Log(LogType.Info, "Listening on 7332");

                int index = 0;
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    Thread thread = new Thread(HandleClient);
                    thread.Name = "[" + index.ToString() + "]";
                    thread.Start(client);
                    index++;
                }
            }
            catch (Exception ex)
            {
                e.Result = ex.Message;
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            String message = e.UserState.ToString();
            LogType type = (LogType)e.ProgressPercentage;

            switch (type)
            {
                case LogType.NowPlaying:
                    lblNowPlaying.Text = "Now Playing: " + message;
                    break;
                default:
                    lstOutput.Items.Add(message);
                    lstOutput.TopIndex = lstOutput.Items.Count - 1;
                    break;
            }
        }

        private void HandleClient(object client_obj)
        {
            string name = Thread.CurrentThread.Name;
            FileStream[] files = new FileStream[256];

            try
            {
                TcpClient client = (TcpClient)client_obj;
                using (NetworkStream stream = client.GetStream())
                {
                    EndianBinaryReader reader = new EndianBinaryReader(stream);
                    EndianBinaryWriter writer = new EndianBinaryWriter(stream);

                    uint[] ids = reader.ReadUInt32s(4);

                    bool isSplatoon = false;
                    var titleId = ids[0].ToString("X8") + "-" + ids[1].ToString("X8");

                    // North America, Europe, Japan
                    if (titleId.Equals("00050000-10176900") || titleId.Equals("00050000-10176A00") || titleId.Equals("00050000-10162B00"))
                    {
                        isSplatoon = true;
                    }

                    Log(LogType.Info, name + " Accepted connection from client " + client.Client.RemoteEndPoint.ToString() + ((isSplatoon) ? " (Splatoon)" : ""));

                    writer.Write(BYTE_SPECIAL);

                    while (true)
                    {
                        byte cmd_byte = reader.ReadByte();
                        switch (cmd_byte)
                        {
                            case BYTE_OPEN:
                                {
                                    int len_path = reader.ReadInt32();
                                    int len_mode = reader.ReadInt32();
                                    string path = reader.ReadString(Encoding.ASCII, len_path - 1);
                                    if (reader.ReadByte() != 0) throw new InvalidDataException();
                                    string mode = reader.ReadString(Encoding.ASCII, len_mode - 1);
                                    if (reader.ReadByte() != 0) throw new InvalidDataException();

                                    if (isSplatoon)
                                    {
                                        String localPath = "other_files" + path;
                                        Log(LogType.Info, name + "request: " + localPath);
                                        if (path.Contains(".bfstm"))
                                        {
                                            String strippedPath = Path.GetFileName(path);
                                            strippedPath = strippedPath.Substring(0, strippedPath.Length - 6);

                                            MusicFile musicFile;
                                            if (playNext != null)
                                            {
                                                musicFile = playNext;
                                                playNext = null;
                                            }
                                            else
                                            {
                                                TrackType trackType = TrackTypeUtils.FileNameToTrackType(Path.GetFileName(path));
                                                if (trackType == TrackType.Unknown)
                                                {
                                                    writer.Write(BYTE_NORMAL);
                                                    break;
                                                }

                                                musicFile = fileTrackers[(int)trackType].getTrack(this.playMode);
                                                if (musicFile == null)
                                                {
                                                    Log(LogType.NowPlaying, strippedPath);
                                                    writer.Write(BYTE_NORMAL);
                                                    break;
                                                }
                                            }

                                            Log(LogType.Info, name + " Replacing " + strippedPath + " with " + musicFile.fileName);
                                            Log(LogType.NowPlaying, musicFile.fileName);

                                            localPath = musicFile.path;
                                        }
                                        else if (File.Exists(localPath))
                                        {
                                            Log(LogType.Info, name + " Replacing " + path);
                                        }
                                        else
                                        {
                                            // not a music file and the file doesn't exist in our cafiine directory
                                            writer.Write(BYTE_NORMAL);
                                            break;
                                        }

                                        int handle = -1;
                                        for (int i = 0; i < files.Length; i++)
                                        {
                                            if (files[i] == null)
                                            {
                                                handle = i;
                                                break;
                                            }
                                        }

                                        if (handle == -1)
                                        {
                                            Log(LogType.Error, name + " Out of file handles!");
                                            writer.Write(BYTE_SPECIAL);
                                            writer.Write(-19);
                                            writer.Write(0);
                                            break;
                                        }

                                        files[handle] = new FileStream(localPath, FileMode.Open, FileAccess.Read, FileShare.Read);

                                        writer.Write(BYTE_SPECIAL);
                                        writer.Write(0);
                                        writer.Write(0x0fff00ff | (handle << 8));
                                    }
                                    else
                                    {
                                        // not from splatoon, so just ignore this request
                                        writer.Write(BYTE_NORMAL);
                                    }

                                    break;
                                }
                            case BYTE_HANDLE:
                                {
                                    // Read buffer params : fd, path length, path string
                                    int fd = reader.ReadInt32();
                                    int len_path = reader.ReadInt32();
                                    string path = reader.ReadString(Encoding.ASCII, len_path - 1);
                                    if (reader.ReadByte() != 0) throw new InvalidDataException();

                                    // Send response
                                    writer.Write(BYTE_SPECIAL);
                                    break;
                                }
                            case BYTE_DUMP:
                                {
                                    // Read buffer params : fd, size, file data
                                    int fd = reader.ReadInt32();
                                    int sz = reader.ReadInt32();

                                    // Send response
                                    writer.Write(BYTE_SPECIAL);
                                    break;
                                }
                            case BYTE_READ:
                                {
                                    int size = reader.ReadInt32();
                                    int count = reader.ReadInt32();
                                    int fd = reader.ReadInt32();
                                    if ((fd & 0x0fff00ff) == 0x0fff00ff)
                                    {
                                        int handle = (fd >> 8) & 0xff;
                                        if (files[handle] == null)
                                        {
                                            writer.Write(BYTE_SPECIAL);
                                            writer.Write(-19);
                                            writer.Write(0);
                                            break;
                                        }
                                        FileStream f = files[handle];

                                        byte[] buffer = new byte[size * count];
                                        int sz = f.Read(buffer, 0, buffer.Length);
                                        writer.Write(BYTE_SPECIAL);
                                        writer.Write(sz / size);
                                        writer.Write(sz);
                                        writer.Write(buffer, 0, sz);
                                        if (reader.ReadByte() != BYTE_OK)
                                            throw new InvalidDataException();
                                    }
                                    else
                                    {
                                        writer.Write(BYTE_NORMAL);
                                    }
                                    break;
                                }
                            case BYTE_CLOSE:
                                {
                                    int fd = reader.ReadInt32();
                                    if ((fd & 0x0fff00ff) == 0x0fff00ff)
                                    {
                                        int handle = (fd >> 8) & 0xff;
                                        if (files[handle] == null)
                                        {
                                            writer.Write(BYTE_SPECIAL);
                                            writer.Write(-38);
                                            break;
                                        }

                                        Log(LogType.Info, name + " close(" + handle.ToString() + ")");
                                        FileStream f = files[handle];

                                        writer.Write(BYTE_SPECIAL);
                                        writer.Write(0);
                                        f.Close();
                                        files[handle] = null;
                                    }
                                    else
                                    {
                                        // Send response
                                        writer.Write(BYTE_NORMAL);
                                    }
                                    break;
                                }
                            case BYTE_SETPOS:
                                {
                                    int fd = reader.ReadInt32();
                                    int pos = reader.ReadInt32();
                                    if ((fd & 0x0fff00ff) == 0x0fff00ff)
                                    {
                                        int handle = (fd >> 8) & 0xff;
                                        if (files[handle] == null)
                                        {
                                            writer.Write(BYTE_SPECIAL);
                                            writer.Write(-38);
                                            break;
                                        }
                                        FileStream f = files[handle];

                                        f.Position = pos;
                                        writer.Write(BYTE_SPECIAL);
                                        writer.Write(0);
                                    }
                                    else
                                    {
                                        writer.Write(BYTE_NORMAL);
                                    }
                                    break;
                                }
                            case BYTE_STATFILE:
                                {
                                    int fd = reader.ReadInt32();
                                    if ((fd & 0x0fff00ff) == 0x0fff00ff)
                                    {
                                        int handle = (fd >> 8) & 0xff;
                                        if (files[handle] == null)
                                        {
                                            writer.Write(BYTE_SPECIAL);
                                            writer.Write(-38);
                                            writer.Write(0);
                                            break;
                                        }
                                        FileStream f = files[handle];

                                        FSStat stat = new FSStat();

                                        stat.flags = FSStatFlag.None;
                                        stat.permission = 0x400;
                                        stat.owner = ids[1];
                                        stat.group = 0x101e;
                                        stat.file_size = (uint)f.Length;

                                        writer.Write(BYTE_SPECIAL);
                                        writer.Write(0);
                                        writer.Write(Marshal.SizeOf(stat));
                                        writer.Write(stat);
                                    }
                                    else
                                    {
                                        writer.Write(BYTE_NORMAL);
                                    }
                                    break;
                                }
                            case BYTE_EOF:
                                {
                                    int fd = reader.ReadInt32();
                                    if ((fd & 0x0fff00ff) == 0x0fff00ff)
                                    {
                                        int handle = (fd >> 8) & 0xff;
                                        if (files[handle] == null)
                                        {
                                            writer.Write(BYTE_SPECIAL);
                                            writer.Write(-38);
                                            break;
                                        }
                                        FileStream f = files[handle];

                                        writer.Write(BYTE_SPECIAL);
                                        writer.Write(f.Position == f.Length ? -5 : 0);
                                    }
                                    else
                                    {
                                        writer.Write(BYTE_NORMAL);
                                    }
                                    break;
                                }
                            case BYTE_GETPOS:
                                {
                                    int fd = reader.ReadInt32();
                                    if ((fd & 0x0fff00ff) == 0x0fff00ff)
                                    {
                                        int handle = (fd >> 8) & 0xff;
                                        if (files[handle] == null)
                                        {
                                            writer.Write(BYTE_SPECIAL);
                                            writer.Write(-38);
                                            writer.Write(0);
                                            break;
                                        }
                                        FileStream f = files[handle];

                                        writer.Write(BYTE_SPECIAL);
                                        writer.Write(0);
                                        writer.Write((int)f.Position);
                                    }
                                    else
                                    {
                                        writer.Write(BYTE_NORMAL);
                                    }
                                    break;
                                }
                            case BYTE_PING:
                                {
                                    int val1 = reader.ReadInt32();
                                    int val2 = reader.ReadInt32();

                                    Log(LogType.Info, name + " PING RECEIVED with values : " + val1.ToString() + " - " + val2.ToString());
                                    break;
                                }
                            default:
                                throw new InvalidDataException();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log(LogType.Error, name + " " + ex.Message);
            }
            finally
            {
                foreach (var item in files)
                {
                    if (item != null)
                        item.Close();
                }
            }
            Log(LogType.Info, name + " Exit");
        }

        private void lsvTracks_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lsvTracks.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenu.Show(Cursor.Position);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusicFile file = musicFiles[lsvTracks.SelectedIndices[0]];

            ImportForm importForm = new ImportForm(file);
            importForm.ShowDialog(this);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusicFile file = musicFiles[lsvTracks.SelectedIndices[0]];

            foreach (FileTracker tracker in fileTrackers)
            {
                tracker.files.Remove(file);
            }

            musicFiles.Remove(file);
            lsvTracks.Items.RemoveAt(lsvTracks.SelectedIndices[0]);

            SaveTrackList();
        }

        private void btnPlayNext_Click(object sender, EventArgs e)
        {
            if (lsvTracks.SelectedIndices == null)
            {
                return;
            }

            playNext = musicFiles[lsvTracks.SelectedIndices[0]];
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm();
            importForm.ShowDialog(this);
        }

        private void radShuffle_CheckedChanged(object sender, EventArgs e)
        {
            if (radShuffle.Checked)
            {
                this.playMode = PlayMode.Shuffle;
            }
        }

        private void radInOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (radInOrder.Checked)
            {
                this.playMode = PlayMode.InOrder;
            }
        }

        private void radTrueRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (radTrueRandom.Checked)
            {
                this.playMode = PlayMode.TrueRandom;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/OatmealDome/SplatoonUtilities/blob/master/MusicRandomizer/README.md");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
