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
            this.grpMultiplayer = new System.Windows.Forms.GroupBox();
            this.chkVictoryJingle = new System.Windows.Forms.CheckBox();
            this.chkDefeatJingle = new System.Windows.Forms.CheckBox();
            this.chkLobby = new System.Windows.Forms.CheckBox();
            this.chkVSVictory = new System.Windows.Forms.CheckBox();
            this.chkVSDefeat = new System.Windows.Forms.CheckBox();
            this.chkOneMinute = new System.Windows.Forms.CheckBox();
            this.chkVSBackground = new System.Windows.Forms.CheckBox();
            this.chkIntro = new System.Windows.Forms.CheckBox();
            this.chkMatchmaking = new System.Windows.Forms.CheckBox();
            this.grpSolo = new System.Windows.Forms.GroupBox();
            this.chkWorld = new System.Windows.Forms.CheckBox();
            this.chkFinalCheckpoint = new System.Windows.Forms.CheckBox();
            this.chkSoloVictory = new System.Windows.Forms.CheckBox();
            this.chkSoloDefeat = new System.Windows.Forms.CheckBox();
            this.chkSoloMission = new System.Windows.Forms.CheckBox();
            this.chkGateway = new System.Windows.Forms.CheckBox();
            this.grpTypes = new System.Windows.Forms.GroupBox();
            this.grpOther = new System.Windows.Forms.GroupBox();
            this.chkNewsEnding = new System.Windows.Forms.CheckBox();
            this.chkNews = new System.Windows.Forms.CheckBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.grpMultiplayer.SuspendLayout();
            this.grpSolo.SuspendLayout();
            this.grpTypes.SuspendLayout();
            this.grpOther.SuspendLayout();
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
            // grpMultiplayer
            // 
            this.grpMultiplayer.Controls.Add(this.chkVictoryJingle);
            this.grpMultiplayer.Controls.Add(this.chkDefeatJingle);
            this.grpMultiplayer.Controls.Add(this.chkLobby);
            this.grpMultiplayer.Controls.Add(this.chkVSVictory);
            this.grpMultiplayer.Controls.Add(this.chkVSDefeat);
            this.grpMultiplayer.Controls.Add(this.chkOneMinute);
            this.grpMultiplayer.Controls.Add(this.chkVSBackground);
            this.grpMultiplayer.Controls.Add(this.chkIntro);
            this.grpMultiplayer.Controls.Add(this.chkMatchmaking);
            this.grpMultiplayer.Location = new System.Drawing.Point(10, 45);
            this.grpMultiplayer.Name = "grpMultiplayer";
            this.grpMultiplayer.Size = new System.Drawing.Size(144, 231);
            this.grpMultiplayer.TabIndex = 2;
            this.grpMultiplayer.TabStop = false;
            this.grpMultiplayer.Text = "Multiplayer";
            // 
            // chkVictoryJingle
            // 
            this.chkVictoryJingle.AutoSize = true;
            this.chkVictoryJingle.Location = new System.Drawing.Point(9, 134);
            this.chkVictoryJingle.Name = "chkVictoryJingle";
            this.chkVictoryJingle.Size = new System.Drawing.Size(88, 17);
            this.chkVictoryJingle.TabIndex = 9;
            this.chkVictoryJingle.Text = "Victory Jingle";
            this.chkVictoryJingle.UseVisualStyleBackColor = true;
            // 
            // chkDefeatJingle
            // 
            this.chkDefeatJingle.AutoSize = true;
            this.chkDefeatJingle.Location = new System.Drawing.Point(9, 180);
            this.chkDefeatJingle.Name = "chkDefeatJingle";
            this.chkDefeatJingle.Size = new System.Drawing.Size(88, 17);
            this.chkDefeatJingle.TabIndex = 8;
            this.chkDefeatJingle.Text = "Defeat Jingle";
            this.chkDefeatJingle.UseVisualStyleBackColor = true;
            // 
            // chkLobby
            // 
            this.chkLobby.AutoSize = true;
            this.chkLobby.Location = new System.Drawing.Point(9, 19);
            this.chkLobby.Name = "chkLobby";
            this.chkLobby.Size = new System.Drawing.Size(84, 17);
            this.chkLobby.TabIndex = 7;
            this.chkLobby.Text = "Plaza Lobby";
            this.chkLobby.UseVisualStyleBackColor = true;
            // 
            // chkVSVictory
            // 
            this.chkVSVictory.AutoSize = true;
            this.chkVSVictory.Location = new System.Drawing.Point(9, 157);
            this.chkVSVictory.Name = "chkVSVictory";
            this.chkVSVictory.Size = new System.Drawing.Size(58, 17);
            this.chkVSVictory.TabIndex = 6;
            this.chkVSVictory.Text = "Victory";
            this.chkVSVictory.UseVisualStyleBackColor = true;
            // 
            // chkVSDefeat
            // 
            this.chkVSDefeat.AutoSize = true;
            this.chkVSDefeat.Location = new System.Drawing.Point(9, 203);
            this.chkVSDefeat.Name = "chkVSDefeat";
            this.chkVSDefeat.Size = new System.Drawing.Size(58, 17);
            this.chkVSDefeat.TabIndex = 5;
            this.chkVSDefeat.Text = "Defeat";
            this.chkVSDefeat.UseVisualStyleBackColor = true;
            // 
            // chkOneMinute
            // 
            this.chkOneMinute.AutoSize = true;
            this.chkOneMinute.Location = new System.Drawing.Point(9, 111);
            this.chkOneMinute.Name = "chkOneMinute";
            this.chkOneMinute.Size = new System.Drawing.Size(134, 17);
            this.chkOneMinute.TabIndex = 4;
            this.chkOneMinute.Text = "One Minute Remaining";
            this.chkOneMinute.UseVisualStyleBackColor = true;
            // 
            // chkVSBackground
            // 
            this.chkVSBackground.AutoSize = true;
            this.chkVSBackground.Location = new System.Drawing.Point(9, 88);
            this.chkVSBackground.Name = "chkVSBackground";
            this.chkVSBackground.Size = new System.Drawing.Size(115, 17);
            this.chkVSBackground.TabIndex = 3;
            this.chkVSBackground.Text = "Background Music";
            this.chkVSBackground.UseVisualStyleBackColor = true;
            // 
            // chkIntro
            // 
            this.chkIntro.AutoSize = true;
            this.chkIntro.Location = new System.Drawing.Point(9, 65);
            this.chkIntro.Name = "chkIntro";
            this.chkIntro.Size = new System.Drawing.Size(77, 17);
            this.chkIntro.TabIndex = 2;
            this.chkIntro.Text = "Intro Jingle";
            this.chkIntro.UseVisualStyleBackColor = true;
            // 
            // chkMatchmaking
            // 
            this.chkMatchmaking.AutoSize = true;
            this.chkMatchmaking.Location = new System.Drawing.Point(9, 42);
            this.chkMatchmaking.Name = "chkMatchmaking";
            this.chkMatchmaking.Size = new System.Drawing.Size(90, 17);
            this.chkMatchmaking.TabIndex = 1;
            this.chkMatchmaking.Text = "Matchmaking";
            this.chkMatchmaking.UseVisualStyleBackColor = true;
            // 
            // grpSolo
            // 
            this.grpSolo.Controls.Add(this.chkWorld);
            this.grpSolo.Controls.Add(this.chkFinalCheckpoint);
            this.grpSolo.Controls.Add(this.chkSoloVictory);
            this.grpSolo.Controls.Add(this.chkSoloDefeat);
            this.grpSolo.Controls.Add(this.chkSoloMission);
            this.grpSolo.Controls.Add(this.chkGateway);
            this.grpSolo.Location = new System.Drawing.Point(160, 45);
            this.grpSolo.Name = "grpSolo";
            this.grpSolo.Size = new System.Drawing.Size(144, 159);
            this.grpSolo.TabIndex = 7;
            this.grpSolo.TabStop = false;
            this.grpSolo.Text = "Single Player";
            // 
            // chkWorld
            // 
            this.chkWorld.AutoSize = true;
            this.chkWorld.Location = new System.Drawing.Point(9, 19);
            this.chkWorld.Name = "chkWorld";
            this.chkWorld.Size = new System.Drawing.Size(77, 17);
            this.chkWorld.TabIndex = 8;
            this.chkWorld.Text = "Hub World";
            this.chkWorld.UseVisualStyleBackColor = true;
            // 
            // chkFinalCheckpoint
            // 
            this.chkFinalCheckpoint.AutoSize = true;
            this.chkFinalCheckpoint.Location = new System.Drawing.Point(9, 88);
            this.chkFinalCheckpoint.Name = "chkFinalCheckpoint";
            this.chkFinalCheckpoint.Size = new System.Drawing.Size(105, 17);
            this.chkFinalCheckpoint.TabIndex = 7;
            this.chkFinalCheckpoint.Text = "Final Checkpoint";
            this.chkFinalCheckpoint.UseVisualStyleBackColor = true;
            // 
            // chkSoloVictory
            // 
            this.chkSoloVictory.AutoSize = true;
            this.chkSoloVictory.Location = new System.Drawing.Point(9, 111);
            this.chkSoloVictory.Name = "chkSoloVictory";
            this.chkSoloVictory.Size = new System.Drawing.Size(58, 17);
            this.chkSoloVictory.TabIndex = 6;
            this.chkSoloVictory.Text = "Victory";
            this.chkSoloVictory.UseVisualStyleBackColor = true;
            // 
            // chkSoloDefeat
            // 
            this.chkSoloDefeat.AutoSize = true;
            this.chkSoloDefeat.Location = new System.Drawing.Point(9, 134);
            this.chkSoloDefeat.Name = "chkSoloDefeat";
            this.chkSoloDefeat.Size = new System.Drawing.Size(58, 17);
            this.chkSoloDefeat.TabIndex = 5;
            this.chkSoloDefeat.Text = "Defeat";
            this.chkSoloDefeat.UseVisualStyleBackColor = true;
            // 
            // chkSoloMission
            // 
            this.chkSoloMission.AutoSize = true;
            this.chkSoloMission.Location = new System.Drawing.Point(9, 65);
            this.chkSoloMission.Name = "chkSoloMission";
            this.chkSoloMission.Size = new System.Drawing.Size(115, 17);
            this.chkSoloMission.TabIndex = 2;
            this.chkSoloMission.Text = "Background Music";
            this.chkSoloMission.UseVisualStyleBackColor = true;
            // 
            // chkGateway
            // 
            this.chkGateway.AutoSize = true;
            this.chkGateway.Location = new System.Drawing.Point(9, 42);
            this.chkGateway.Name = "chkGateway";
            this.chkGateway.Size = new System.Drawing.Size(113, 17);
            this.chkGateway.TabIndex = 1;
            this.chkGateway.Text = "Standing on Kettle";
            this.chkGateway.UseVisualStyleBackColor = true;
            // 
            // grpTypes
            // 
            this.grpTypes.Controls.Add(this.grpOther);
            this.grpTypes.Controls.Add(this.lblPrompt);
            this.grpTypes.Controls.Add(this.grpSolo);
            this.grpTypes.Controls.Add(this.grpMultiplayer);
            this.grpTypes.Location = new System.Drawing.Point(13, 39);
            this.grpTypes.Name = "grpTypes";
            this.grpTypes.Size = new System.Drawing.Size(316, 283);
            this.grpTypes.TabIndex = 8;
            this.grpTypes.TabStop = false;
            this.grpTypes.Text = "Types";
            // 
            // grpOther
            // 
            this.grpOther.Controls.Add(this.chkNewsEnding);
            this.grpOther.Controls.Add(this.chkNews);
            this.grpOther.Location = new System.Drawing.Point(160, 210);
            this.grpOther.Name = "grpOther";
            this.grpOther.Size = new System.Drawing.Size(144, 66);
            this.grpOther.TabIndex = 8;
            this.grpOther.TabStop = false;
            this.grpOther.Text = "Other";
            // 
            // chkNewsEnding
            // 
            this.chkNewsEnding.AutoSize = true;
            this.chkNewsEnding.Location = new System.Drawing.Point(9, 38);
            this.chkNewsEnding.Name = "chkNewsEnding";
            this.chkNewsEnding.Size = new System.Drawing.Size(89, 17);
            this.chkNewsEnding.TabIndex = 1;
            this.chkNewsEnding.Text = "News Ending";
            this.chkNewsEnding.UseVisualStyleBackColor = true;
            // 
            // chkNews
            // 
            this.chkNews.AutoSize = true;
            this.chkNews.Location = new System.Drawing.Point(9, 15);
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
            this.grpMultiplayer.ResumeLayout(false);
            this.grpMultiplayer.PerformLayout();
            this.grpSolo.ResumeLayout(false);
            this.grpSolo.PerformLayout();
            this.grpTypes.ResumeLayout(false);
            this.grpTypes.PerformLayout();
            this.grpOther.ResumeLayout(false);
            this.grpOther.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox grpMultiplayer;
        private System.Windows.Forms.CheckBox chkOneMinute;
        private System.Windows.Forms.CheckBox chkVSBackground;
        private System.Windows.Forms.CheckBox chkIntro;
        private System.Windows.Forms.CheckBox chkMatchmaking;
        private System.Windows.Forms.CheckBox chkVSVictory;
        private System.Windows.Forms.CheckBox chkVSDefeat;
        private System.Windows.Forms.GroupBox grpSolo;
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
        private System.Windows.Forms.GroupBox grpOther;
        private System.Windows.Forms.CheckBox chkNewsEnding;
        private System.Windows.Forms.CheckBox chkNews;
    }
}