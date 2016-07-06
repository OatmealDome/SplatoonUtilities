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

            String[] playlists = Directory.GetFiles("playlists");
            foreach (String playlist in playlists)
            {
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

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String oldName = (String)lstPlaylists.SelectedItem;

            NewPlaylistForm newPlaylistForm = new NewPlaylistForm(oldName);
            newPlaylistForm.ShowDialog();

            // Rename the playlist
            File.Move("playlists\\" + oldName + ".xml", "playlists\\" + newPlaylistForm.name + ".xml");
            ReloadPlaylists();

            // Check if this is the current playlist and update Configuration if it is
            if (Configuration.currentConfig.currentPlaylist.Equals(oldName))
            {
                Configuration.currentConfig.currentPlaylist = newPlaylistForm.name;
            }
        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String toDuplicate = (String)lstPlaylists.SelectedItem;

            NewPlaylistForm newPlaylistForm = new NewPlaylistForm(toDuplicate + " (Copy)");
            newPlaylistForm.ShowDialog();

            // Duplicate the playlist
            File.Copy("playlists\\" + toDuplicate + ".xml", "playlists\\" + newPlaylistForm.name + ".xml");
            ReloadPlaylists();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String selectedPlaylist = (String)lstPlaylists.SelectedItem;

            // Check if the playlist we are about to delete is the current one
            if (Configuration.currentConfig.currentPlaylist.Equals(selectedPlaylist))
            {
                // Refuse to do this
                MessageBox.Show("You cannot remove the current playlist.");
                return;
            }

            File.Delete("playlists\\" + selectedPlaylist + ".xml");
            ReloadPlaylists();
        }

        private void lstPlaylists_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rightClickOver = lstPlaylists.IndexFromPoint(e.X, e.Y);
                if (rightClickOver >= 0)
                {
                    lstPlaylists.SelectedIndex = rightClickOver;
                    contextMenu.Show(Cursor.Position);
                }
            }
        }

    }
}
