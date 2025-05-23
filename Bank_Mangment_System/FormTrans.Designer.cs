namespace Bank_Mangment_System
{
    partial class FormTrans
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
            this.pnlAccountNotFond = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.llInfo = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbSearchAccount = new System.Windows.Forms.PictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTrans = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAccountNotFond.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchAccount)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAccountNotFond
            // 
            this.pnlAccountNotFond.Controls.Add(this.label2);
            this.pnlAccountNotFond.Controls.Add(this.pictureBox1);
            this.pnlAccountNotFond.Location = new System.Drawing.Point(-8, 149);
            this.pnlAccountNotFond.Name = "pnlAccountNotFond";
            this.pnlAccountNotFond.Size = new System.Drawing.Size(1233, 398);
            this.pnlAccountNotFond.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(490, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Not Found";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank_Mangment_System.Properties.Resources.cross;
            this.pictureBox1.Location = new System.Drawing.Point(393, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // llInfo
            // 
            this.llInfo.AutoSize = true;
            this.llInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llInfo.Font = new System.Drawing.Font("Tahoma", 25.8F);
            this.llInfo.Location = new System.Drawing.Point(671, 392);
            this.llInfo.Name = "llInfo";
            this.llInfo.Size = new System.Drawing.Size(99, 52);
            this.llInfo.TabIndex = 12;
            this.llInfo.TabStop = true;
            this.llInfo.Text = "Info";
            this.llInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llInfo_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(516, 52);
            this.label3.TabIndex = 18;
            this.label3.Text = "Get Account Information :";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(558, 212);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 52);
            this.lblBalance.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 52);
            this.label1.TabIndex = 16;
            this.label1.Text = "Your Account Has :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel3.Controls.Add(this.pbSearchAccount);
            this.panel3.Controls.Add(this.guna2TextBox1);
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1225, 77);
            this.panel3.TabIndex = 15;
            // 
            // pbSearchAccount
            // 
            this.pbSearchAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearchAccount.Image = global::Bank_Mangment_System.Properties.Resources.user_avatar;
            this.pbSearchAccount.Location = new System.Drawing.Point(1074, 3);
            this.pbSearchAccount.Name = "pbSearchAccount";
            this.pbSearchAccount.Size = new System.Drawing.Size(100, 58);
            this.pbSearchAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchAccount.TabIndex = 6;
            this.pbSearchAccount.TabStop = false;
            this.pbSearchAccount.Click += new System.EventHandler(this.pbSearchAccount_Click_1);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(8, 17);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(344, 36);
            this.guna2TextBox1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.btnTrans);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 550);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1233, 54);
            this.panel2.TabIndex = 14;
            // 
            // btnTrans
            // 
            this.btnTrans.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTrans.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrans.Location = new System.Drawing.Point(488, 3);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(246, 45);
            this.btnTrans.TabIndex = 0;
            this.btnTrans.Text = "Enter reciver Account";
            this.btnTrans.UseVisualStyleBackColor = false;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 68);
            this.panel1.TabIndex = 13;
            // 
            // FormTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 605);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlAccountNotFond);
            this.Controls.Add(this.llInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormTrans";
            this.Text = "FormTrans";
            this.Load += new System.EventHandler(this.FormTrans_Load);
            this.pnlAccountNotFond.ResumeLayout(false);
            this.pnlAccountNotFond.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchAccount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccountNotFond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbSearchAccount;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Panel panel1;
    }
}