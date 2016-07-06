namespace MusicRandomizer
{
    partial class PlaylistsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstPlaylists = new System.Windows.Forms.ListBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSwapTo = new System.Windows.Forms.Button();
            this.grpPlaylists = new System.Windows.Forms.GroupBox();
            this.lblCurrentPlaylist = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpPlaylists.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPlaylists
            // 
            this.lstPlaylists.FormattingEnabled = true;
            this.lstPlaylists.Location = new System.Drawing.Point(6, 19);
            this.lstPlaylists.Name = "lstPlaylists";
            this.lstPlaylists.Size = new System.Drawing.Size(258, 108);
            this.lstPlaylists.TabIndex = 0;
            this.lstPlaylists.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstPlaylists_MouseClick);
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(13, 13);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(261, 26);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "Manage your playlists here. Right click on a playlist for\r\nmore options.";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(76, 198);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSwapTo
            // 
            this.btnSwapTo.Location = new System.Drawing.Point(157, 198);
            this.btnSwapTo.Name = "btnSwapTo";
            this.btnSwapTo.Size = new System.Drawing.Size(75, 23);
            this.btnSwapTo.TabIndex = 3;
            this.btnSwapTo.Text = "Swap To";
            this.btnSwapTo.UseVisualStyleBackColor = true;
            this.btnSwapTo.Click += new System.EventHandler(this.btnSwapTo_Click);
            // 
            // grpPlaylists
            // 
            this.grpPlaylists.Controls.Add(this.lblCurrentPlaylist);
            this.grpPlaylists.Controls.Add(this.lstPlaylists);
            this.grpPlaylists.Location = new System.Drawing.Point(16, 42);
            this.grpPlaylists.Name = "grpPlaylists";
            this.grpPlaylists.Size = new System.Drawing.Size(274, 150);
            this.grpPlaylists.TabIndex = 4;
            this.grpPlaylists.TabStop = false;
            this.grpPlaylists.Text = "Playlists";
            // 
            // lblCurrentPlaylist
            // 
            this.lblCurrentPlaylist.AutoSize = true;
            this.lblCurrentPlaylist.Location = new System.Drawing.Point(3, 132);
            this.lblCurrentPlaylist.Name = "lblCurrentPlaylist";
            this.lblCurrentPlaylist.Size = new System.Drawing.Size(102, 13);
            this.lblCurrentPlaylist.TabIndex = 1;
            this.lblCurrentPlaylist.Text = "Current Playlist: N/A";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // PlaylistsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 230);
            this.Controls.Add(this.grpPlaylists);
            this.Controls.Add(this.btnSwapTo);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblPrompt);
            this.Name = "PlaylistsForm";
            this.Text = "PlaylistsForm";
            this.Load += new System.EventHandler(this.PlaylistsForm_Load);
            this.grpPlaylists.ResumeLayout(false);
            this.grpPlaylists.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPlaylists;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSwapTo;
        private System.Windows.Forms.GroupBox grpPlaylists;
        private System.Windows.Forms.Label lblCurrentPlaylist;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}