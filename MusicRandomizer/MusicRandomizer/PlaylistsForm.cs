using System;
using System.IO;
using System.Windows.Forms;

namespace MusicRandomizer
{
    public partial class PlaylistsForm : Form
    {
        public PlaylistsForm()
        {
            InitializeComponent();
        }

        private void PlaylistsForm_Load(object sender, EventArgs e)
        {
            ReloadPlaylists();
        }

        private void ReloadPlaylists()
        {
            lstPlaylists.Items.Clear();
            lstPlaylists.Items.Add("Default"); // force Default to be at the top

            String[] playlists = Directory.GetFiles("playlists");
            foreach (String playlist in playlists)
            {
                if (playlist.Equals("playlists\\Default.xml"))
                {
                    // skip this, we added it earlier
                    continue;
                }

                String playlistFilename = playlist.Substring(10, playlist.Length - 10); // strip "playlists\"
                String playlistName = playlistFilename.Substring(0, playlistFilename.Length - 4); // strip ".xml"
                lstPlaylists.Items.Add(playlistName);
            }

            lblCurrentPlaylist.Text = "Current Playlist: " + Configuration.currentConfig.currentPlaylist;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewPlaylistForm newPlaylistForm = new NewPlaylistForm();
            newPlaylistForm.ShowDialog();

            ReloadPlaylists();
        }

        private void btnSwapTo_Click(object sender, EventArgs e)
        {
            String selectedPlaylist = (String)lstPlaylists.SelectedItem;

            MainForm mainForm = (MainForm)this.Owner;
            mainForm.SwitchPlaylist(selectedPlaylist);

            ReloadPlaylists();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String selectedPlaylist = (String)lstPlaylists.SelectedItem;

            // Make sure they're not attempting to remove "Default"
            if (selectedPlaylist.Equals("Default"))
            {
                MessageBox.Show("You cannot remove the default playlist.");
                return;
            }

            File.Delete(selectedPlaylist);

            // Check if the playlist we just deleted is the current one
            if (Configuration.currentConfig.currentPlaylist.Equals(selectedPlaylist))
            {
                // Change the current playlist to Default
                MainForm mainForm = (MainForm)this.Owner;
                mainForm.SwitchPlaylist("Default");
            }
        }

        private void lstPlaylists_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rightClickOver = lstPlaylists.IndexFromPoint(e.X, e.Y);
                if (rightClickOver >= 0)
                {
                    lstPlaylists.SelectedIndex = rightClickOver;
                    contextMenuStrip.Show(Cursor.Position);
                }
            }
        }
    }
}
