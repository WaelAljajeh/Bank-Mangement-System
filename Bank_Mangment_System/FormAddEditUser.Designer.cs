namespace Bank_Mangment_System
{
    partial class FormAddEditUser
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
            this.pnlFormat = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFormattxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerAnimateLabel = new System.Windows.Forms.Timer(this.components);
            this.timerChangeLabel = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbRemoveImage = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.pbUserImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudSalary = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.pbEyePassword = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSelectAll = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbMangeUsers = new System.Windows.Forms.CheckBox();
            this.cbShowClients = new System.Windows.Forms.CheckBox();
            this.cbFindClient = new System.Windows.Forms.CheckBox();
            this.cbAddClient = new System.Windows.Forms.CheckBox();
            this.cbUpdateClient = new System.Windows.Forms.CheckBox();
            this.cbDeleteClient = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTrans = new System.Windows.Forms.CheckBox();
            this.cbCurrency = new System.Windows.Forms.CheckBox();
            this.cbUserLogs = new System.Windows.Forms.CheckBox();
            this.pnlFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEyePassword)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormat
            // 
            this.pnlFormat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlFormat.Controls.Add(this.lblFormattxt);
            this.pnlFormat.Controls.Add(this.pictureBox1);
            this.pnlFormat.Location = new System.Drawing.Point(1, 2);
            this.pnlFormat.Name = "pnlFormat";
            this.pnlFormat.Size = new System.Drawing.Size(674, 643);
            this.pnlFormat.TabIndex = 1;
            // 
            // lblFormattxt
            // 
            this.lblFormattxt.AutoSize = true;
            this.lblFormattxt.Font = new System.Drawing.Font("Tahoma", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormattxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormattxt.Location = new System.Drawing.Point(143, 311);
            this.lblFormattxt.Name = "lblFormattxt";
            this.lblFormattxt.Size = new System.Drawing.Size(440, 80);
            this.lblFormattxt.TabIndex = 1;
            this.lblFormattxt.Text = "Welcome to\r\nBank Mangement System\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank_Mangment_System.Properties.Resources.bank_building;
            this.pictureBox1.Location = new System.Drawing.Point(146, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timerAnimateLabel
            // 
            this.timerAnimateLabel.Interval = 200;
            this.timerAnimateLabel.Tick += new System.EventHandler(this.timerAnimateLabel_Tick);
            // 
            // timerChangeLabel
            // 
            this.timerChangeLabel.Interval = 10000;
            this.timerChangeLabel.Tick += new System.EventHandler(this.timerChangeLabel_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbRemoveImage);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblUserID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.pbUserImage);
            this.panel1.Location = new System.Drawing.Point(678, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 308);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pbRemoveImage
            // 
            this.pbRemoveImage.Image = global::Bank_Mangment_System.Properties.Resources.rubbish_bin;
            this.pbRemoveImage.Location = new System.Drawing.Point(686, 98);
            this.pbRemoveImage.Name = "pbRemoveImage";
            this.pbRemoveImage.Size = new System.Drawing.Size(22, 29);
            this.pbRemoveImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRemoveImage.TabIndex = 12;
            this.pbRemoveImage.TabStop = false;
            this.pbRemoveImage.Click += new System.EventHandler(this.pbRemoveImage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "UserID";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(200, 42);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(37, 24);
            this.lblUserID.TabIndex = 5;
            this.lblUserID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(204, 245);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(461, 24);
            this.txtEmail.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(204, 168);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(461, 24);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(204, 107);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(461, 24);
            this.txtFirstName.TabIndex = 0;
            // 
            // pbUserImage
            // 
            this.pbUserImage.Image = global::Bank_Mangment_System.Properties.Resources.userImage;
            this.pbUserImage.ImageRotate = 0F;
            this.pbUserImage.Location = new System.Drawing.Point(686, 0);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbUserImage.Size = new System.Drawing.Size(123, 127);
            this.pbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserImage.TabIndex = 11;
            this.pbUserImage.TabStop = false;
            this.pbUserImage.Click += new System.EventHandler(this.pbCustomerImage_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(1124, 605);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(304, 42);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(717, 603);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(304, 42);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nudSalary);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pbEyePassword);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(678, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 141);
            this.panel2.TabIndex = 11;
            // 
            // nudSalary
            // 
            this.nudSalary.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudSalary.Location = new System.Drawing.Point(204, 115);
            this.nudSalary.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSalary.Name = "nudSalary";
            this.nudSalary.Size = new System.Drawing.Size(120, 24);
            this.nudSalary.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Salary";
            // 
            // pbEyePassword
            // 
            this.pbEyePassword.Image = global::Bank_Mangment_System.Properties.Resources.eye1;
            this.pbEyePassword.ImageRotate = 0F;
            this.pbEyePassword.Location = new System.Drawing.Point(633, 73);
            this.pbEyePassword.Name = "pbEyePassword";
            this.pbEyePassword.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbEyePassword.Size = new System.Drawing.Size(42, 24);
            this.pbEyePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEyePassword.TabIndex = 22;
            this.pbEyePassword.TabStop = false;
            this.pbEyePassword.Click += new System.EventHandler(this.pbEyePassword_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(204, 21);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(461, 24);
            this.txtUsername.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(204, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(461, 24);
            this.txtPassword.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Username";
            // 
            // cbSelectAll
            // 
            this.cbSelectAll.AutoSize = true;
            this.cbSelectAll.Location = new System.Drawing.Point(3, 17);
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.Size = new System.Drawing.Size(82, 21);
            this.cbSelectAll.TabIndex = 14;
            this.cbSelectAll.Text = "Select All";
            this.cbSelectAll.UseVisualStyleBackColor = true;
            this.cbSelectAll.CheckedChanged += new System.EventHandler(this.cbSelectAll_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbUserLogs);
            this.panel3.Controls.Add(this.cbCurrency);
            this.panel3.Controls.Add(this.cbTrans);
            this.panel3.Controls.Add(this.cbSelectAll);
            this.panel3.Controls.Add(this.cbMangeUsers);
            this.panel3.Controls.Add(this.cbShowClients);
            this.panel3.Controls.Add(this.cbFindClient);
            this.panel3.Controls.Add(this.cbAddClient);
            this.panel3.Controls.Add(this.cbUpdateClient);
            this.panel3.Controls.Add(this.cbDeleteClient);
            this.panel3.Location = new System.Drawing.Point(678, 503);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(839, 85);
            this.panel3.TabIndex = 14;
            // 
            // cbMangeUsers
            // 
            this.cbMangeUsers.AutoSize = true;
            this.cbMangeUsers.Location = new System.Drawing.Point(3, 61);
            this.cbMangeUsers.Name = "cbMangeUsers";
            this.cbMangeUsers.Size = new System.Drawing.Size(107, 21);
            this.cbMangeUsers.TabIndex = 20;
            this.cbMangeUsers.Text = "Mange Users";
            this.cbMangeUsers.UseVisualStyleBackColor = true;
            // 
            // cbShowClients
            // 
            this.cbShowClients.AutoSize = true;
            this.cbShowClients.Location = new System.Drawing.Point(120, 17);
            this.cbShowClients.Name = "cbShowClients";
            this.cbShowClients.Size = new System.Drawing.Size(107, 21);
            this.cbShowClients.TabIndex = 15;
            this.cbShowClients.Text = "Show Clients";
            this.cbShowClients.UseVisualStyleBackColor = true;
            // 
            // cbFindClient
            // 
            this.cbFindClient.AutoSize = true;
            this.cbFindClient.Location = new System.Drawing.Point(645, 17);
            this.cbFindClient.Name = "cbFindClient";
            this.cbFindClient.Size = new System.Drawing.Size(92, 21);
            this.cbFindClient.TabIndex = 19;
            this.cbFindClient.Text = "Find Client";
            this.cbFindClient.UseVisualStyleBackColor = true;
            // 
            // cbAddClient
            // 
            this.cbAddClient.AutoSize = true;
            this.cbAddClient.Location = new System.Drawing.Point(260, 17);
            this.cbAddClient.Name = "cbAddClient";
            this.cbAddClient.Size = new System.Drawing.Size(91, 21);
            this.cbAddClient.TabIndex = 16;
            this.cbAddClient.Text = "Add Client";
            this.cbAddClient.UseVisualStyleBackColor = true;
            // 
            // cbUpdateClient
            // 
            this.cbUpdateClient.AutoSize = true;
            this.cbUpdateClient.Location = new System.Drawing.Point(515, 17);
            this.cbUpdateClient.Name = "cbUpdateClient";
            this.cbUpdateClient.Size = new System.Drawing.Size(111, 21);
            this.cbUpdateClient.TabIndex = 18;
            this.cbUpdateClient.Text = "Update Client";
            this.cbUpdateClient.UseVisualStyleBackColor = true;
            // 
            // cbDeleteClient
            // 
            this.cbDeleteClient.AutoSize = true;
            this.cbDeleteClient.Location = new System.Drawing.Point(386, 17);
            this.cbDeleteClient.Name = "cbDeleteClient";
            this.cbDeleteClient.Size = new System.Drawing.Size(105, 21);
            this.cbDeleteClient.TabIndex = 17;
            this.cbDeleteClient.Text = "Delete Client";
            this.cbDeleteClient.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(987, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Set Permissions";
            // 
            // cbTrans
            // 
            this.cbTrans.AutoSize = true;
            this.cbTrans.Location = new System.Drawing.Point(122, 61);
            this.cbTrans.Name = "cbTrans";
            this.cbTrans.Size = new System.Drawing.Size(105, 21);
            this.cbTrans.TabIndex = 21;
            this.cbTrans.Text = "Transaction ";
            this.cbTrans.UseVisualStyleBackColor = true;
            // 
            // cbCurrency
            // 
            this.cbCurrency.AutoSize = true;
            this.cbCurrency.Location = new System.Drawing.Point(260, 61);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(87, 21);
            this.cbCurrency.TabIndex = 22;
            this.cbCurrency.Text = "Currency";
            this.cbCurrency.UseVisualStyleBackColor = true;
            // 
            // cbUserLogs
            // 
            this.cbUserLogs.AutoSize = true;
            this.cbUserLogs.Location = new System.Drawing.Point(386, 61);
            this.cbUserLogs.Name = "cbUserLogs";
            this.cbUserLogs.Size = new System.Drawing.Size(128, 21);
            this.cbUserLogs.TabIndex = 23;
            this.cbUserLogs.Text = "Show User Logs";
            this.cbUserLogs.UseVisualStyleBackColor = true;
            // 
            // FormAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 659);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFormat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel3);
            this.Name = "FormAddEditUser";
            this.Text = "FormAddEditUser";
            this.Load += new System.EventHandler(this.FormAddEditUser_Load);
            this.pnlFormat.ResumeLayout(false);
            this.pnlFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEyePassword)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlFormat;
        private System.Windows.Forms.Label lblFormattxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerAnimateLabel;
        private System.Windows.Forms.Timer timerChangeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbRemoveImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbUserImage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbUpdateClient;
        private System.Windows.Forms.CheckBox cbDeleteClient;
        private System.Windows.Forms.CheckBox cbAddClient;
        private System.Windows.Forms.CheckBox cbShowClients;
        private System.Windows.Forms.CheckBox cbSelectAll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbMangeUsers;
        private System.Windows.Forms.CheckBox cbFindClient;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbEyePassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudSalary;
        private System.Windows.Forms.CheckBox cbTrans;
        private System.Windows.Forms.CheckBox cbUserLogs;
        private System.Windows.Forms.CheckBox cbCurrency;
    }
}