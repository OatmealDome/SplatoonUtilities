namespace MusicRandomizer
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpTracks = new System.Windows.Forms.GroupBox();
            this.lsvTracks = new System.Windows.Forms.ListView();
            this.hdrName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrPlaysAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNowPlaying = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.radTrueRandom = new System.Windows.Forms.RadioButton();
            this.radInOrder = new System.Windows.Forms.RadioButton();
            this.radShuffle = new System.Windows.Forms.RadioButton();
            this.btnPlayNext = new System.Windows.Forms.Button();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.grpTracks.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpControls.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(486, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // grpTracks
            // 
            this.grpTracks.Controls.Add(this.lsvTracks);
            this.grpTracks.Controls.Add(this.lblNowPlaying);
            this.grpTracks.Location = new System.Drawing.Point(12, 27);
            this.grpTracks.Name = "grpTracks";
            this.grpTracks.Size = new System.Drawing.Size(459, 207);
            this.grpTracks.TabIndex = 1;
            this.grpTracks.TabStop = false;
            this.grpTracks.Text = "Tracks";
            // 
            // lsvTracks
            // 
            this.lsvTracks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrName,
            this.hdrPlaysAt});
            this.lsvTracks.Location = new System.Drawing.Point(9, 19);
            this.lsvTracks.MultiSelect = false;
            this.lsvTracks.Name = "lsvTracks";
            this.lsvTracks.Size = new System.Drawing.Size(444, 162);
            this.lsvTracks.TabIndex = 5;
            this.lsvTracks.UseCompatibleStateImageBehavior = false;
            this.lsvTracks.View = System.Windows.Forms.View.Details;
            this.lsvTracks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvTracks_MouseClick);
            // 
            // hdrName
            // 
            this.hdrName.Text = "Name";
            this.hdrName.Width = 100;
            // 
            // hdrPlaysAt
            // 
            this.hdrPlaysAt.Text = "Plays At";
            this.hdrPlaysAt.Width = 340;
            // 
            // lblNowPlaying
            // 
            this.lblNowPlaying.AutoSize = true;
            this.lblNowPlaying.Location = new System.Drawing.Point(6, 185);
            this.lblNowPlaying.Name = "lblNowPlaying";
            this.lblNowPlaying.Size = new System.Drawing.Size(89, 13);
            this.lblNowPlaying.TabIndex = 4;
            this.lblNowPlaying.Text = "Now Playing: n/a";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstOutput);
            this.groupBox1.Location = new System.Drawing.Point(197, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 136);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.HorizontalScrollbar = true;
            this.lstOutput.Location = new System.Drawing.Point(6, 19);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(270, 108);
            this.lstOutput.TabIndex = 0;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.btnImport);
            this.grpControls.Controls.Add(this.radTrueRandom);
            this.grpControls.Controls.Add(this.radInOrder);
            this.grpControls.Controls.Add(this.radShuffle);
            this.grpControls.Controls.Add(this.btnPlayNext);
            this.grpControls.Location = new System.Drawing.Point(12, 245);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(177, 131);
            this.grpControls.TabIndex = 5;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(96, 19);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import File";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // radTrueRandom
            // 
            this.radTrueRandom.AutoSize = true;
            this.radTrueRandom.Location = new System.Drawing.Point(9, 68);
            this.radTrueRandom.Name = "radTrueRandom";
            this.radTrueRandom.Size = new System.Drawing.Size(65, 17);
            this.radTrueRandom.TabIndex = 7;
            this.radTrueRandom.Text = "Random";
            this.radTrueRandom.UseVisualStyleBackColor = true;
            this.radTrueRandom.CheckedChanged += new System.EventHandler(this.radTrueRandom_CheckedChanged);
            // 
            // radInOrder
            // 
            this.radInOrder.AutoSize = true;
            this.radInOrder.Location = new System.Drawing.Point(9, 45);
            this.radInOrder.Name = "radInOrder";
            this.radInOrder.Size = new System.Drawing.Size(63, 17);
            this.radInOrder.TabIndex = 6;
            this.radInOrder.Text = "In Order";
            this.radInOrder.UseVisualStyleBackColor = true;
            this.radInOrder.CheckedChanged += new System.EventHandler(this.radInOrder_CheckedChanged);
            // 
            // radShuffle
            // 
            this.radShuffle.AutoSize = true;
            this.radShuffle.Checked = true;
            this.radShuffle.Location = new System.Drawing.Point(9, 22);
            this.radShuffle.Name = "radShuffle";
            this.radShuffle.Size = new System.Drawing.Size(58, 17);
            this.radShuffle.TabIndex = 5;
            this.radShuffle.TabStop = true;
            this.radShuffle.Text = "Shuffle";
            this.radShuffle.UseVisualStyleBackColor = true;
            this.radShuffle.CheckedChanged += new System.EventHandler(this.radShuffle_CheckedChanged);
            // 
            // btnPlayNext
            // 
            this.btnPlayNext.Location = new System.Drawing.Point(96, 48);
            this.btnPlayNext.Name = "btnPlayNext";
            this.btnPlayNext.Size = new System.Drawing.Size(75, 23);
            this.btnPlayNext.TabIndex = 0;
            this.btnPlayNext.Text = "Play Next";
            this.btnPlayNext.UseVisualStyleBackColor = true;
            this.btnPlayNext.Click += new System.EventHandler(this.btnPlayNext_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(118, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usageToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // usageToolStripMenuItem
            // 
            this.usageToolStripMenuItem.Name = "usageToolStripMenuItem";
            this.usageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usageToolStripMenuItem.Text = "Usage";
            this.usageToolStripMenuItem.Click += new System.EventHandler(this.usageToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 385);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpTracks);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Splatoon Music Randomizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.grpTracks.ResumeLayout(false);
            this.grpTracks.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpTracks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstOutput;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label lblNowPlaying;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Button btnPlayNext;
        private System.Windows.Forms.RadioButton radTrueRandom;
        private System.Windows.Forms.RadioButton radInOrder;
        private System.Windows.Forms.RadioButton radShuffle;
        private System.Windows.Forms.ListView lsvTracks;
        private System.Windows.Forms.ColumnHeader hdrName;
        private System.Windows.Forms.ColumnHeader hdrPlaysAt;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

