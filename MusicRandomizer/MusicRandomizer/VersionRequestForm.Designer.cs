namespace MusicRandomizer
{
    partial class VersionRequestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpRegions = new System.Windows.Forms.GroupBox();
            this.radNorthAmerica = new System.Windows.Forms.RadioButton();
            this.radEurope = new System.Windows.Forms.RadioButton();
            this.radJapan = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpRegions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "What region is your Splatoon copy in? (The files in the \r\n\"other_files\" folder wi" +
    "ll be moved to a new folder named\r\nafter the region you pick here.)";
            // 
            // grpRegions
            // 
            this.grpRegions.Controls.Add(this.btnSave);
            this.grpRegions.Controls.Add(this.radJapan);
            this.grpRegions.Controls.Add(this.radEurope);
            this.grpRegions.Controls.Add(this.radNorthAmerica);
            this.grpRegions.Location = new System.Drawing.Point(15, 51);
            this.grpRegions.Name = "grpRegions";
            this.grpRegions.Size = new System.Drawing.Size(261, 100);
            this.grpRegions.TabIndex = 1;
            this.grpRegions.TabStop = false;
            this.grpRegions.Text = "Regions";
            // 
            // radNorthAmerica
            // 
            this.radNorthAmerica.AutoSize = true;
            this.radNorthAmerica.Location = new System.Drawing.Point(7, 20);
            this.radNorthAmerica.Name = "radNorthAmerica";
            this.radNorthAmerica.Size = new System.Drawing.Size(98, 17);
            this.radNorthAmerica.TabIndex = 0;
            this.radNorthAmerica.TabStop = true;
            this.radNorthAmerica.Text = "North American";
            this.radNorthAmerica.UseVisualStyleBackColor = true;
            // 
            // radEurope
            // 
            this.radEurope.AutoSize = true;
            this.radEurope.Location = new System.Drawing.Point(7, 43);
            this.radEurope.Name = "radEurope";
            this.radEurope.Size = new System.Drawing.Size(71, 17);
            this.radEurope.TabIndex = 1;
            this.radEurope.TabStop = true;
            this.radEurope.Text = "European";
            this.radEurope.UseVisualStyleBackColor = true;
            // 
            // radJapan
            // 
            this.radJapan.AutoSize = true;
            this.radJapan.Location = new System.Drawing.Point(7, 66);
            this.radJapan.Name = "radJapan";
            this.radJapan.Size = new System.Drawing.Size(71, 17);
            this.radJapan.TabIndex = 2;
            this.radJapan.TabStop = true;
            this.radJapan.Text = "Japanese";
            this.radJapan.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(171, 63);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // VersionRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 162);
            this.Controls.Add(this.grpRegions);
            this.Controls.Add(this.label1);
            this.Name = "VersionRequestForm";
            this.Text = "Version Request";
            this.Load += new System.EventHandler(this.VersionRequestForm_Load);
            this.grpRegions.ResumeLayout(false);
            this.grpRegions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpRegions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton radJapan;
        private System.Windows.Forms.RadioButton radEurope;
        private System.Windows.Forms.RadioButton radNorthAmerica;
    }
}