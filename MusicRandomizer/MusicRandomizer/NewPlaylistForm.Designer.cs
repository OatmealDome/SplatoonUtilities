namespace MusicRandomizer
{
    partial class NewPlaylistForm
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.grpName = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpName.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(12, 9);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(175, 13);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Enter in a name for this new playlist.";
            // 
            // grpName
            // 
            this.grpName.Controls.Add(this.txtName);
            this.grpName.Location = new System.Drawing.Point(13, 26);
            this.grpName.Name = "grpName";
            this.grpName.Size = new System.Drawing.Size(185, 56);
            this.grpName.TabIndex = 1;
            this.grpName.TabStop = false;
            this.grpName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(7, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 20);
            this.txtName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(69, 88);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NewPlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 122);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpName);
            this.Controls.Add(this.lblPrompt);
            this.Name = "NewPlaylistForm";
            this.Text = "New Playlist";
            this.grpName.ResumeLayout(false);
            this.grpName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.GroupBox grpName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
    }
}