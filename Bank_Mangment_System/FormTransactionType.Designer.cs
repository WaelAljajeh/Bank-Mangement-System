namespace Bank_Mangment_System
{
    partial class FormTransactionType
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTrans = new System.Windows.Forms.Label();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblTransLogs = new System.Windows.Forms.Label();
            this.pbDeposit = new System.Windows.Forms.PictureBox();
            this.pbWithdraw = new System.Windows.Forms.PictureBox();
            this.pbTrans = new System.Windows.Forms.PictureBox();
            this.pbTransLos = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWithdraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTransLos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pbTransLos);
            this.panel1.Controls.Add(this.lblTransLogs);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 54);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 54);
            this.panel2.TabIndex = 2;
            // 
            // lblTrans
            // 
            this.lblTrans.AutoSize = true;
            this.lblTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTrans.Font = new System.Drawing.Font("Akhbar MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTrans.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTrans.Location = new System.Drawing.Point(73, 236);
            this.lblTrans.Name = "lblTrans";
            this.lblTrans.Size = new System.Drawing.Size(174, 42);
            this.lblTrans.TabIndex = 6;
            this.lblTrans.Text = "Transaction";
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWithdraw.Font = new System.Drawing.Font("Akhbar MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblWithdraw.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWithdraw.Location = new System.Drawing.Point(450, 236);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(144, 42);
            this.lblWithdraw.TabIndex = 7;
            this.lblWithdraw.Text = "Withdraw";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDeposit.Font = new System.Drawing.Font("Akhbar MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDeposit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDeposit.Location = new System.Drawing.Point(798, 236);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(119, 42);
            this.lblDeposit.TabIndex = 8;
            this.lblDeposit.Text = "Deposit";
            // 
            // lblTransLogs
            // 
            this.lblTransLogs.AutoSize = true;
            this.lblTransLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTransLogs.Font = new System.Drawing.Font("Akhbar MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTransLogs.ForeColor = System.Drawing.Color.Honeydew;
            this.lblTransLogs.Location = new System.Drawing.Point(95, 7);
            this.lblTransLogs.Name = "lblTransLogs";
            this.lblTransLogs.Size = new System.Drawing.Size(257, 42);
            this.lblTransLogs.TabIndex = 9;
            this.lblTransLogs.Text = "Transaction_Logs";
            // 
            // pbDeposit
            // 
            this.pbDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDeposit.Image = global::Bank_Mangment_System.Properties.Resources.deposit;
            this.pbDeposit.Location = new System.Drawing.Point(768, 78);
            this.pbDeposit.Name = "pbDeposit";
            this.pbDeposit.Size = new System.Drawing.Size(187, 133);
            this.pbDeposit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDeposit.TabIndex = 5;
            this.pbDeposit.TabStop = false;
            this.pbDeposit.Click += new System.EventHandler(this.pbDeposit_Click);
            // 
            // pbWithdraw
            // 
            this.pbWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbWithdraw.Image = global::Bank_Mangment_System.Properties.Resources.atmWithDraw;
            this.pbWithdraw.Location = new System.Drawing.Point(426, 78);
            this.pbWithdraw.Name = "pbWithdraw";
            this.pbWithdraw.Size = new System.Drawing.Size(187, 133);
            this.pbWithdraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWithdraw.TabIndex = 4;
            this.pbWithdraw.TabStop = false;
            this.pbWithdraw.Click += new System.EventHandler(this.pbWithdraw_Click);
            // 
            // pbTrans
            // 
            this.pbTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTrans.Image = global::Bank_Mangment_System.Properties.Resources.cash_flow;
            this.pbTrans.Location = new System.Drawing.Point(70, 78);
            this.pbTrans.Name = "pbTrans";
            this.pbTrans.Size = new System.Drawing.Size(187, 133);
            this.pbTrans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrans.TabIndex = 3;
            this.pbTrans.TabStop = false;
            this.pbTrans.Click += new System.EventHandler(this.pbTrans_Click);
            // 
            // pbTransLos
            // 
            this.pbTransLos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTransLos.Image = global::Bank_Mangment_System.Properties.Resources.money_back_guarantee;
            this.pbTransLos.Location = new System.Drawing.Point(3, 5);
            this.pbTransLos.Name = "pbTransLos";
            this.pbTransLos.Size = new System.Drawing.Size(86, 46);
            this.pbTransLos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTransLos.TabIndex = 10;
            this.pbTransLos.TabStop = false;
            this.pbTransLos.Click += new System.EventHandler(this.pbTransLos_Click);
            // 
            // FormTransactionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 337);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblWithdraw);
            this.Controls.Add(this.lblTrans);
            this.Controls.Add(this.pbDeposit);
            this.Controls.Add(this.pbWithdraw);
            this.Controls.Add(this.pbTrans);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormTransactionType";
            this.Text = "FormTransType";
            this.Load += new System.EventHandler(this.FormTransactionType_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWithdraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTransLos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbTrans;
        private System.Windows.Forms.PictureBox pbWithdraw;
        private System.Windows.Forms.PictureBox pbDeposit;
        private System.Windows.Forms.Label lblTrans;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblTransLogs;
        private System.Windows.Forms.PictureBox pbTransLos;
    }
}