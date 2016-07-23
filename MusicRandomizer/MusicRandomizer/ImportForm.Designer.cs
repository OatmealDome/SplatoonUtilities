namespace MusicRandomizer
{
    partial class ImportForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.chkVictoryJingle = new System.Windows.Forms.CheckBox();
            this.chkDefeatJingle = new System.Windows.Forms.CheckBox();
            this.chkLobby = new System.Windows.Forms.CheckBox();
            this.chkVSVictory = new System.Windows.Forms.CheckBox();
            this.chkVSDefeat = new System.Windows.Forms.CheckBox();
            this.chkOneMinute = new System.Windows.Forms.CheckBox();
            this.chkVSBackground = new System.Windows.Forms.CheckBox();
            this.chkIntro = new System.Windows.Forms.CheckBox();
            this.chkMatchmaking = new System.Windows.Forms.CheckBox();
            this.chkWorld = new System.Windows.Forms.CheckBox();
            this.chkFinalCheckpoint = new System.Windows.Forms.CheckBox();
            this.chkSoloVictory = new System.Windows.Forms.CheckBox();
            this.chkSoloDefeat = new System.Windows.Forms.CheckBox();
            this.chkSoloMission = new System.Windows.Forms.CheckBox();
            this.chkGateway = new System.Windows.Forms.CheckBox();
            this.grpTypes = new System.Windows.Forms.GroupBox();
            this.trackTabControl = new System.Windows.Forms.TabControl();
            this.tabMultiplayer = new System.Windows.Forms.TabPage();
            this.tabSinglePlayer = new System.Windows.Forms.TabPage();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.chkNewsEnding = new System.Windows.Forms.CheckBox();
            this.chkNews = new System.Windows.Forms.CheckBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.grpTypes.SuspendLayout();
            this.trackTabControl.SuspendLayout();
            this.tabMultiplayer.SuspendLayout();
            this.tabSinglePlayer.SuspendLayout();
            this.tabOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "BFSTM files|*.bfstm";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(236, 20);
            this.txtFilePath.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(254, 10);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // chkVictoryJingle
            // 
            this.chkVictoryJingle.AutoSize = true;
            this.chkVictoryJingle.Location = new System.Drawing.Point(6, 121);
            this.chkVictoryJingle.Name = "chkVictoryJingle";
            this.chkVictoryJingle.Size = new System.Drawing.Size(88, 17);
            this.chkVictoryJingle.TabIndex = 9;
            this.chkVictoryJingle.Text = "Victory Jingle";
            this.chkVictoryJingle.UseVisualStyleBackColor = true;
            // 
            // chkDefeatJingle
            // 
            this.chkDefeatJingle.AutoSize = true;
            this.chkDefeatJingle.Location = new System.Drawing.Point(6, 167);
            this.chkDefeatJingle.Name = "chkDefeatJingle";
            this.chkDefeatJingle.Size = new System.Drawing.Size(88, 17);
            this.chkDefeatJingle.TabIndex = 8;
            this.chkDefeatJingle.Text = "Defeat Jingle";
            this.chkDefeatJingle.UseVisualStyleBackColor = true;
            // 
            // chkLobby
            // 
            this.chkLobby.AutoSize = true;
            this.chkLobby.Location = new System.Drawing.Point(6, 6);
            this.chkLobby.Name = "chkLobby";
            this.chkLobby.Size = new System.Drawing.Size(84, 17);
            this.chkLobby.TabIndex = 7;
            this.chkLobby.Text = "Plaza Lobby";
            this.chkLobby.UseVisualStyleBackColor = true;
            // 
            // chkVSVictory
            // 
            this.chkVSVictory.AutoSize = true;
            this.chkVSVictory.Location = new System.Drawing.Point(6, 144);
            this.chkVSVictory.Name = "chkVSVictory";
            this.chkVSVictory.Size = new System.Drawing.Size(58, 17);
            this.chkVSVictory.TabIndex = 6;
            this.chkVSVictory.Text = "Victory";
            this.chkVSVictory.UseVisualStyleBackColor = true;
            // 
            // chkVSDefeat
            // 
            this.chkVSDefeat.AutoSize = true;
            this.chkVSDefeat.Location = new System.Drawing.Point(6, 190);
            this.chkVSDefeat.Name = "chkVSDefeat";
            this.chkVSDefeat.Size = new System.Drawing.Size(58, 17);
            this.chkVSDefeat.TabIndex = 5;
            this.chkVSDefeat.Text = "Defeat";
            this.chkVSDefeat.UseVisualStyleBackColor = true;
            // 
            // chkOneMinute
            // 
            this.chkOneMinute.AutoSize = true;
            this.chkOneMinute.Location = new System.Drawing.Point(6, 98);
            this.chkOneMinute.Name = "chkOneMinute";
            this.chkOneMinute.Size = new System.Drawing.Size(134, 17);
            this.chkOneMinute.TabIndex = 4;
            this.chkOneMinute.Text = "One Minute Remaining";
            this.chkOneMinute.UseVisualStyleBackColor = true;
            // 
            // chkVSBackground
            // 
            this.chkVSBackground.AutoSize = true;
            this.chkVSBackground.Location = new System.Drawing.Point(6, 75);
            this.chkVSBackground.Name = "chkVSBackground";
            this.chkVSBackground.Size = new System.Drawing.Size(115, 17);
            this.chkVSBackground.TabIndex = 3;
            this.chkVSBackground.Text = "Background Music";
            this.chkVSBackground.UseVisualStyleBackColor = true;
            // 
            // chkIntro
            // 
            this.chkIntro.AutoSize = true;
            this.chkIntro.Location = new System.Drawing.Point(6, 52);
            this.chkIntro.Name = "chkIntro";
            this.chkIntro.Size = new System.Drawing.Size(77, 17);
            this.chkIntro.TabIndex = 2;
            this.chkIntro.Text = "Intro Jingle";
            this.chkIntro.UseVisualStyleBackColor = true;
            // 
            // chkMatchmaking
            // 
            this.chkMatchmaking.AutoSize = true;
            this.chkMatchmaking.Location = new System.Drawing.Point(6, 29);
            this.chkMatchmaking.Name = "chkMatchmaking";
            this.chkMatchmaking.Size = new System.Drawing.Size(90, 17);
            this.chkMatchmaking.TabIndex = 1;
            this.chkMatchmaking.Text = "Matchmaking";
            this.chkMatchmaking.UseVisualStyleBackColor = true;
            // 
            // chkWorld
            // 
            this.chkWorld.AutoSize = true;
            this.chkWorld.Location = new System.Drawing.Point(6, 6);
            this.chkWorld.Name = "chkWorld";
            this.chkWorld.Size = new System.Drawing.Size(77, 17);
            this.chkWorld.TabIndex = 8;
            this.chkWorld.Text = "Hub World";
            this.chkWorld.UseVisualStyleBackColor = true;
            this.chkWorld.CheckedChanged += new System.EventHandler(this.chkWorld_CheckedChanged);
            // 
            // chkFinalCheckpoint
            // 
            this.chkFinalCheckpoint.AutoSize = true;
            this.chkFinalCheckpoint.Location = new System.Drawing.Point(6, 75);
            this.chkFinalCheckpoint.Name = "chkFinalCheckpoint";
            this.chkFinalCheckpoint.Size = new System.Drawing.Size(105, 17);
            this.chkFinalCheckpoint.TabIndex = 7;
            this.chkFinalCheckpoint.Text = "Final Checkpoint";
            this.chkFinalCheckpoint.UseVisualStyleBackColor = true;
            // 
            // chkSoloVictory
            // 
            this.chkSoloVictory.AutoSize = true;
            this.chkSoloVictory.Location = new System.Drawing.Point(6, 98);
            this.chkSoloVictory.Name = "chkSoloVictory";
            this.chkSoloVictory.Size = new System.Drawing.Size(58, 17);
            this.chkSoloVictory.TabIndex = 6;
            this.chkSoloVictory.Text = "Victory";
            this.chkSoloVictory.UseVisualStyleBackColor = true;
            // 
            // chkSoloDefeat
            // 
            this.chkSoloDefeat.AutoSize = true;
            this.chkSoloDefeat.Location = new System.Drawing.Point(6, 121);
            this.chkSoloDefeat.Name = "chkSoloDefeat";
            this.chkSoloDefeat.Size = new System.Drawing.Size(58, 17);
            this.chkSoloDefeat.TabIndex = 5;
            this.chkSoloDefeat.Text = "Defeat";
            this.chkSoloDefeat.UseVisualStyleBackColor = true;
            // 
            // chkSoloMission
            // 
            this.chkSoloMission.AutoSize = true;
            this.chkSoloMission.Location = new System.Drawing.Point(6, 52);
            this.chkSoloMission.Name = "chkSoloMission";
            this.chkSoloMission.Size = new System.Drawing.Size(115, 17);
            this.chkSoloMission.TabIndex = 2;
            this.chkSoloMission.Text = "Background Music";
            this.chkSoloMission.UseVisualStyleBackColor = true;
            // 
            // chkGateway
            // 
            this.chkGateway.AutoSize = true;
            this.chkGateway.Location = new System.Drawing.Point(6, 29);
            this.chkGateway.Name = "chkGateway";
            this.chkGateway.Size = new System.Drawing.Size(113, 17);
            this.chkGateway.TabIndex = 1;
            this.chkGateway.Text = "Standing on Kettle";
            this.chkGateway.UseVisualStyleBackColor = true;
            // 
            // grpTypes
            // 
            this.grpTypes.Controls.Add(this.trackTabControl);
            this.grpTypes.Controls.Add(this.lblPrompt);
            this.grpTypes.Location = new System.Drawing.Point(13, 39);
            this.grpTypes.Name = "grpTypes";
            this.grpTypes.Size = new System.Drawing.Size(316, 283);
            this.grpTypes.TabIndex = 8;
            this.grpTypes.TabStop = false;
            this.grpTypes.Text = "Types";
            // 
            // trackTabControl
            // 
            this.trackTabControl.Controls.Add(this.tabMultiplayer);
            this.trackTabControl.Controls.Add(this.tabSinglePlayer);
            this.trackTabControl.Controls.Add(this.tabOther);
            this.trackTabControl.Location = new System.Drawing.Point(10, 36);
            this.trackTabControl.Name = "trackTabControl";
            this.trackTabControl.SelectedIndex = 0;
            this.trackTabControl.Size = new System.Drawing.Size(300, 241);
            this.trackTabControl.TabIndex = 10;
            // 
            // tabMultiplayer
            // 
            this.tabMultiplayer.Controls.Add(this.chkVictoryJingle);
            this.tabMultiplayer.Controls.Add(this.chkLobby);
            this.tabMultiplayer.Controls.Add(this.chkDefeatJingle);
            this.tabMultiplayer.Controls.Add(this.chkMatchmaking);
            this.tabMultiplayer.Controls.Add(this.chkIntro);
            this.tabMultiplayer.Controls.Add(this.chkVSVictory);
            this.tabMultiplayer.Controls.Add(this.chkVSBackground);
            this.tabMultiplayer.Controls.Add(this.chkVSDefeat);
            this.tabMultiplayer.Controls.Add(this.chkOneMinute);
            this.tabMultiplayer.Location = new System.Drawing.Point(4, 22);
            this.tabMultiplayer.Name = "tabMultiplayer";
            this.tabMultiplayer.Padding = new System.Windows.Forms.Padding(3);
            this.tabMultiplayer.Size = new System.Drawing.Size(292, 215);
            this.tabMultiplayer.TabIndex = 0;
            this.tabMultiplayer.Text = "Multiplayer";
            this.tabMultiplayer.UseVisualStyleBackColor = true;
            // 
            // tabSinglePlayer
            // 
            this.tabSinglePlayer.Controls.Add(this.chkWorld);
            this.tabSinglePlayer.Controls.Add(this.chkSoloMission);
            this.tabSinglePlayer.Controls.Add(this.chkFinalCheckpoint);
            this.tabSinglePlayer.Controls.Add(this.chkGateway);
            this.tabSinglePlayer.Controls.Add(this.chkSoloVictory);
            this.tabSinglePlayer.Controls.Add(this.chkSoloDefeat);
            this.tabSinglePlayer.Location = new System.Drawing.Point(4, 22);
            this.tabSinglePlayer.Name = "tabSinglePlayer";
            this.tabSinglePlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tabSinglePlayer.Size = new System.Drawing.Size(292, 215);
            this.tabSinglePlayer.TabIndex = 1;
            this.tabSinglePlayer.Text = "Single Player";
            this.tabSinglePlayer.UseVisualStyleBackColor = true;
            // 
            // tabOther
            // 
            this.tabOther.Controls.Add(this.chkNewsEnding);
            this.tabOther.Controls.Add(this.chkNews);
            this.tabOther.Location = new System.Drawing.Point(4, 22);
            this.tabOther.Name = "tabOther";
            this.tabOther.Padding = new System.Windows.Forms.Padding(3);
            this.tabOther.Size = new System.Drawing.Size(292, 215);
            this.tabOther.TabIndex = 2;
            this.tabOther.Text = "Other";
            this.tabOther.UseVisualStyleBackColor = true;
            // 
            // chkNewsEnding
            // 
            this.chkNewsEnding.AutoSize = true;
            this.chkNewsEnding.Location = new System.Drawing.Point(6, 29);
            this.chkNewsEnding.Name = "chkNewsEnding";
            this.chkNewsEnding.Size = new System.Drawing.Size(89, 17);
            this.chkNewsEnding.TabIndex = 1;
            this.chkNewsEnding.Text = "News Ending";
            this.chkNewsEnding.UseVisualStyleBackColor = true;
            // 
            // chkNews
            // 
            this.chkNews.AutoSize = true;
            this.chkNews.Location = new System.Drawing.Point(6, 6);
            this.chkNews.Name = "chkNews";
            this.chkNews.Size = new System.Drawing.Size(53, 17);
            this.chkNews.TabIndex = 0;
            this.chkNews.Text = "News";
            this.chkNews.UseVisualStyleBackColor = true;
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(7, 20);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(144, 13);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "When should this track play?";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(136, 328);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 359);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.grpTypes);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtFilePath);
            this.Name = "ImportForm";
            this.Text = "Import Track";
            this.grpTypes.ResumeLayout(false);
            this.grpTypes.PerformLayout();
            this.trackTabControl.ResumeLayout(false);
            this.tabMultiplayer.ResumeLayout(false);
            this.tabMultiplayer.PerformLayout();
            this.tabSinglePlayer.ResumeLayout(false);
            this.tabSinglePlayer.PerformLayout();
            this.tabOther.ResumeLayout(false);
            this.tabOther.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.CheckBox chkOneMinute;
        private System.Windows.Forms.CheckBox chkVSBackground;
        private System.Windows.Forms.CheckBox chkIntro;
        private System.Windows.Forms.CheckBox chkMatchmaking;
        private System.Windows.Forms.CheckBox chkVSVictory;
        private System.Windows.Forms.CheckBox chkVSDefeat;
        private System.Windows.Forms.CheckBox chkSoloVictory;
        private System.Windows.Forms.CheckBox chkSoloDefeat;
        private System.Windows.Forms.CheckBox chkSoloMission;
        private System.Windows.Forms.CheckBox chkGateway;
        private System.Windows.Forms.CheckBox chkFinalCheckpoint;
        private System.Windows.Forms.GroupBox grpTypes;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.CheckBox chkVictoryJingle;
        private System.Windows.Forms.CheckBox chkDefeatJingle;
        private System.Windows.Forms.CheckBox chkLobby;
        private System.Windows.Forms.CheckBox chkWorld;
        private System.Windows.Forms.CheckBox chkNewsEnding;
        private System.Windows.Forms.CheckBox chkNews;
        private System.Windows.Forms.TabControl trackTabControl;
        private System.Windows.Forms.TabPage tabMultiplayer;
        private System.Windows.Forms.TabPage tabSinglePlayer;
        private System.Windows.Forms.TabPage tabOther;
    }
}