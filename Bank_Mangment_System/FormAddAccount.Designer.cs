namespace Bank_Mangment_System
{
    partial class FormAddAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbRemoveImage = new System.Windows.Forms.PictureBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.pbCustomerImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomerImage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormat
            // 
            this.pnlFormat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlFormat.Controls.Add(this.lblFormattxt);
            this.pnlFormat.Controls.Add(this.pictureBox1);
            this.pnlFormat.Location = new System.Drawing.Point(0, 1);
            this.pnlFormat.Name = "pnlFormat";
            this.pnlFormat.Size = new System.Drawing.Size(678, 643);
            this.pnlFormat.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "FirstName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "CustomerID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Account Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "PIN_Code";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbRemoveImage);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblCustomerID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.pbCustomerImage);
            this.panel1.Location = new System.Drawing.Point(678, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 308);
            this.panel1.TabIndex = 7;
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
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(200, 42);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(37, 24);
            this.lblCustomerID.TabIndex = 5;
            this.lblCustomerID.Text = "???";
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
            // pbCustomerImage
            // 
            this.pbCustomerImage.Image = global::Bank_Mangment_System.Properties.Resources.userImage;
            this.pbCustomerImage.ImageRotate = 0F;
            this.pbCustomerImage.Location = new System.Drawing.Point(686, 0);
            this.pbCustomerImage.Name = "pbCustomerImage";
            this.pbCustomerImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbCustomerImage.Size = new System.Drawing.Size(123, 127);
            this.pbCustomerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCustomerImage.TabIndex = 11;
            this.pbCustomerImage.TabStop = false;
            this.pbCustomerImage.Click += new System.EventHandler(this.pbCustomerImage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAccountNumber);
            this.panel2.Controls.Add(this.txtPin);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(678, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 103);
            this.panel2.TabIndex = 8;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(204, 17);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(145, 24);
            this.txtAccountNumber.TabIndex = 9;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(520, 13);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(145, 24);
            this.txtPin.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(754, 539);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(304, 42);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(1135, 539);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(304, 42);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
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
            // FormAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 646);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlFormat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormAddAccount";
            this.Text = "FormAddAccount";
//            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddAccount_FormClosing);
            this.Load += new System.EventHandler(this.FormAddAccount_Load);
            this.pnlFormat.ResumeLayout(false);
            this.pnlFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomerImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlFormat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFormattxt;
        private System.Windows.Forms.Timer timerAnimateLabel;
        private System.Windows.Forms.Timer timerChangeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbRemoveImage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbCustomerImage;
    }
}

