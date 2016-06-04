using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MusicRandomizer
{
    public partial class ImportForm : Form
    {
        private MusicFile file;

        public ImportForm()
        {
            InitializeComponent();

            file = null;
        }

        public ImportForm(MusicFile file)
        {
            InitializeComponent();

            this.file = file;

            txtFilePath.Text = file.path;
            txtFilePath.Enabled = false;
            btnOpen.Enabled = false;

            foreach (TrackType type in file.types)
            {
                switch (type)
                {
                    case TrackType.VSLobby:
                        chkLobby.Checked = true;
                        break;
                    case TrackType.VSWait:
                        chkMatchmaking.Checked = true;
                        break;
                    case TrackType.VSIntro:
                        chkIntro.Checked = true;
                        break;
                    case TrackType.VSBackground:
                        chkVSBackground.Checked = true;
                        break;
                    case TrackType.VSOneMinute:
                        chkOneMinute.Checked = true;
                        break;
                    case TrackType.VSWinJingle:
                        chkVictoryJingle.Checked = true;
                        break;
                    case TrackType.VSWin:
                        chkVSVictory.Checked = true;
                        break;
                    case TrackType.VSLoseJingle:
                        chkDefeatJingle.Checked = false;
                        break;
                    case TrackType.VSLose:
                        chkVSDefeat.Checked = true;
                        break;
                    case TrackType.SoloWorld:
                        chkWorld.Checked = true;
                        break;
                    case TrackType.SoloGateway:
                        chkGateway.Checked = true;
                        break;
                    case TrackType.SoloMission:
                        chkSoloMission.Checked = true;
                        break;
                    case TrackType.SoloFinalCheckpoint:
                        chkFinalCheckpoint.Checked = true;
                        break;
                    case TrackType.SoloWin:
                        chkSoloVictory.Checked = true;
                        break;
                    case TrackType.SoloLose:
                        chkSoloDefeat.Checked = true;
                        break;
                    case TrackType.NewsBackground:
                        chkNews.Checked = true;
                        break;
                    case TrackType.NewsOutro:
                        chkNewsEnding.Checked = true;
                        break;
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            String path = txtFilePath.Text;
            if (!File.Exists(path))
            {
                MessageBox.Show("The file does not exist.");
                return;
            }

            byte[] buffer = new byte[4];
            using (FileStream stream = File.OpenRead(path))
            {
                stream.Read(buffer, 0, buffer.Length);
            }

            byte[] expectedBytes = new byte[] { 0x46, 0x53, 0x54, 0x4d }; // "FSTM"
            if (!buffer.SequenceEqual(expectedBytes))
            {
                MessageBox.Show("The selected file is not a vaild BFSTM file.");
                return;
            }

            if (!chkLobby.Checked && !chkMatchmaking.Checked && !chkIntro.Checked && !chkVSBackground.Checked 
                && !chkOneMinute.Checked && !chkVictoryJingle.Checked && !chkVSVictory.Checked
                && !chkDefeatJingle.Checked && !chkDefeatJingle.Checked && !chkVSDefeat.Checked 
                && !chkGateway.Checked && !chkSoloMission.Checked && !chkFinalCheckpoint.Checked 
                && !chkSoloVictory.Checked && !chkSoloDefeat.Checked && !chkNews.Checked && !chkNewsEnding.Checked)
            {
                MessageBox.Show("Please select at least one case where this track file will play.");
                return;
            }

            List<TrackType> types = new List<TrackType>();

            if (chkLobby.Checked)
            {
                types.Add(TrackType.VSLobby);
            }
            
            if (chkMatchmaking.Checked)
            {
                types.Add(TrackType.VSWait);
            }

            if (chkIntro.Checked)
            {
                types.Add(TrackType.VSIntro);
            }

            if (chkVSBackground.Checked)
            {
                types.Add(TrackType.VSBackground);
            }

            if (chkOneMinute.Checked)
            {
                types.Add(TrackType.VSOneMinute);
            }

            if (chkVictoryJingle.Checked)
            {
                types.Add(TrackType.VSWinJingle);
            }

            if (chkVSVictory.Checked)
            {
                types.Add(TrackType.VSWin);
            }

            if (chkDefeatJingle.Checked)
            {
                types.Add(TrackType.VSLoseJingle);
            }

            if (chkVSDefeat.Checked)
            {
                types.Add(TrackType.VSLose);
            }

            if (chkWorld.Checked)
            {
                types.Add(TrackType.SoloWorld);
            }

            if (chkGateway.Checked)
            {
                types.Add(TrackType.SoloGateway);
            }

            if (chkSoloMission.Checked)
            {
                types.Add(TrackType.SoloMission);
            }

            if (chkFinalCheckpoint.Checked)
            {
                types.Add(TrackType.SoloFinalCheckpoint);
            }

            if (chkSoloVictory.Checked)
            {
                types.Add(TrackType.SoloWin);
            }

            if (chkSoloDefeat.Checked)
            {
                types.Add(TrackType.SoloLose);
            }

            if (chkNews.Checked)
            {
                types.Add(TrackType.NewsBackground);
            }

            if (chkNewsEnding.Checked)
            {
                types.Add(TrackType.NewsOutro);
            }

            MainForm mainForm = (MainForm)this.Owner;

            if (file == null)
            {
                String newPath = Path.Combine("tracks", Path.GetFileName(path));
                File.Delete(newPath);
                File.Copy(path, newPath);

                file = new MusicFile();
                file.path = newPath;
                file.types = types;

                mainForm.musicFiles.Add(file);
            }
            else
            {
                file.types = types;
            }

            mainForm.RefreshTrackList(false);

            this.Close();
        }
    }
}
