namespace Bank_Mangment_System
{
    partial class FormSettings
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
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.lblShowLogs = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.lblNameSettingsUser = new System.Windows.Forms.Label();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlSettings.Controls.Add(this.lblShowLogs);
            this.pnlSettings.Controls.Add(this.lblLogOut);
            this.pnlSettings.Controls.Add(this.lblNameSettingsUser);
            this.pnlSettings.Controls.Add(this.pbImg);
            this.pnlSettings.Location = new System.Drawing.Point(1221, 80);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(227, 392);
            this.pnlSettings.TabIndex = 1;
            // 
            // lblShowLogs
            // 
            this.lblShowLogs.AutoSize = true;
            this.lblShowLogs.Font = new System.Drawing.Font("Yu Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowLogs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShowLogs.Location = new System.Drawing.Point(3, 260);
            this.lblShowLogs.Name = "lblShowLogs";
            this.lblShowLogs.Size = new System.Drawing.Size(179, 26);
            this.lblShowLogs.TabIndex = 3;
            this.lblShowLogs.Text = "Show Login Logs";
            this.lblShowLogs.Click += new System.EventHandler(this.lblShowLogs_Click);
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Yu Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogOut.Location = new System.Drawing.Point(3, 183);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(77, 26);
            this.lblLogOut.TabIndex = 2;
            this.lblLogOut.Text = "logOut";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // lblNameSettingsUser
            // 
            this.lblNameSettingsUser.AutoSize = true;
            this.lblNameSettingsUser.Font = new System.Drawing.Font("Yu Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSettingsUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNameSettingsUser.Location = new System.Drawing.Point(2, 109);
            this.lblNameSettingsUser.Name = "lblNameSettingsUser";
            this.lblNameSettingsUser.Size = new System.Drawing.Size(222, 26);
            this.lblNameSettingsUser.TabIndex = 1;
            this.lblNameSettingsUser.Text = "lblNameSettingsUser";
            this.lblNameSettingsUser.Click += new System.EventHandler(this.lblNameSettingsUser_Click);
            // 
            // pbImg
            // 
            this.pbImg.Image = global::Bank_Mangment_System.Properties.Resources.userImage;
            this.pbImg.Location = new System.Drawing.Point(3, 32);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(61, 57);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            // 
            // pbSettings
            // 
            this.pbSettings.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pbSettings.Image = global::Bank_Mangment_System.Properties.Resources.settings;
            this.pbSettings.Location = new System.Drawing.Point(1385, 12);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(49, 42);
            this.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSettings.TabIndex = 0;
            this.pbSettings.TabStop = false;
            this.pbSettings.Click += new System.EventHandler(this.pbSettings_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 587);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pbSettings);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSettings;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label lblNameSettingsUser;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Label lblShowLogs;
    }
}