namespace Bank_Mangment_System
{
    partial class FormCurrencyCalculator
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
            this.cbFromCurrency = new System.Windows.Forms.ComboBox();
            this.cbToCurrency = new System.Windows.Forms.ComboBox();
            this.btnEnterFrom = new System.Windows.Forms.Button();
            this.cbEnterTo = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAmountOf = new System.Windows.Forms.Label();
            this.lblFirstCurrencyCode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAmountTO = new System.Windows.Forms.Label();
            this.lblToCurrencyCode = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFromCurrency
            // 
            this.cbFromCurrency.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFromCurrency.FormattingEnabled = true;
            this.cbFromCurrency.Items.AddRange(new object[] {
            ""});
            this.cbFromCurrency.Location = new System.Drawing.Point(235, 104);
            this.cbFromCurrency.Name = "cbFromCurrency";
            this.cbFromCurrency.Size = new System.Drawing.Size(235, 24);
            this.cbFromCurrency.TabIndex = 10;
            // 
            // cbToCurrency
            // 
            this.cbToCurrency.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbToCurrency.FormattingEnabled = true;
            this.cbToCurrency.Items.AddRange(new object[] {
            ""});
            this.cbToCurrency.Location = new System.Drawing.Point(235, 290);
            this.cbToCurrency.Name = "cbToCurrency";
            this.cbToCurrency.Size = new System.Drawing.Size(235, 24);
            this.cbToCurrency.TabIndex = 11;
            // 
            // btnEnterFrom
            // 
            this.btnEnterFrom.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterFrom.Location = new System.Drawing.Point(294, 156);
            this.btnEnterFrom.Name = "btnEnterFrom";
            this.btnEnterFrom.Size = new System.Drawing.Size(102, 29);
            this.btnEnterFrom.TabIndex = 12;
            this.btnEnterFrom.Text = "Enter";
            this.btnEnterFrom.UseVisualStyleBackColor = true;
            this.btnEnterFrom.Click += new System.EventHandler(this.btnEnterFrom_Click);
            // 
            // cbEnterTo
            // 
            this.cbEnterTo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnterTo.Location = new System.Drawing.Point(294, 341);
            this.cbEnterTo.Name = "cbEnterTo";
            this.cbEnterTo.Size = new System.Drawing.Size(102, 29);
            this.cbEnterTo.TabIndex = 13;
            this.cbEnterTo.Text = "Enter";
            this.cbEnterTo.UseVisualStyleBackColor = true;
            this.cbEnterTo.Click += new System.EventHandler(this.cbEnterTo_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(182, 508);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(318, 32);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmount.Location = new System.Drawing.Point(277, 436);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(120, 32);
            this.nudAmount.TabIndex = 16;
            this.nudAmount.ValueChanged += new System.EventHandler(this.nudAmount_ValueChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(12, 436);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(112, 34);
            this.lblAmount.TabIndex = 15;
            this.lblAmount.Text = "Amount";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "To Cuurency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 34);
            this.label2.TabIndex = 18;
            this.label2.Text = "From Currency";
            // 
            // lblAmountOf
            // 
            this.lblAmountOf.AutoSize = true;
            this.lblAmountOf.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOf.Location = new System.Drawing.Point(12, 607);
            this.lblAmountOf.Name = "lblAmountOf";
            this.lblAmountOf.Size = new System.Drawing.Size(112, 34);
            this.lblAmountOf.TabIndex = 19;
            this.lblAmountOf.Text = "Amount";
            // 
            // lblFirstCurrencyCode
            // 
            this.lblFirstCurrencyCode.AutoSize = true;
            this.lblFirstCurrencyCode.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstCurrencyCode.Location = new System.Drawing.Point(150, 607);
            this.lblFirstCurrencyCode.Name = "lblFirstCurrencyCode";
            this.lblFirstCurrencyCode.Size = new System.Drawing.Size(112, 34);
            this.lblFirstCurrencyCode.TabIndex = 20;
            this.lblFirstCurrencyCode.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 607);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 34);
            this.label5.TabIndex = 21;
            this.label5.Text = "=";
            // 
            // lblAmountTO
            // 
            this.lblAmountTO.AutoSize = true;
            this.lblAmountTO.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountTO.Location = new System.Drawing.Point(344, 607);
            this.lblAmountTO.Name = "lblAmountTO";
            this.lblAmountTO.Size = new System.Drawing.Size(112, 34);
            this.lblAmountTO.TabIndex = 15;
            this.lblAmountTO.Text = "Amount";
            this.lblAmountTO.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // lblToCurrencyCode
            // 
            this.lblToCurrencyCode.AutoSize = true;
            this.lblToCurrencyCode.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToCurrencyCode.Location = new System.Drawing.Point(493, 607);
            this.lblToCurrencyCode.Name = "lblToCurrencyCode";
            this.lblToCurrencyCode.Size = new System.Drawing.Size(112, 34);
            this.lblToCurrencyCode.TabIndex = 22;
            this.lblToCurrencyCode.Text = "Amount";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormCurrencyCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(712, 736);
            this.Controls.Add(this.lblToCurrencyCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFirstCurrencyCode);
            this.Controls.Add(this.lblAmountOf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.lblAmountTO);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cbEnterTo);
            this.Controls.Add(this.btnEnterFrom);
            this.Controls.Add(this.cbToCurrency);
            this.Controls.Add(this.cbFromCurrency);
            this.Name = "FormCurrencyCalculator";
            this.Text = "FormCurrencyCalculator";
            this.Load += new System.EventHandler(this.FormCurrencyCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFromCurrency;
        private System.Windows.Forms.ComboBox cbToCurrency;
        private System.Windows.Forms.Button btnEnterFrom;
        private System.Windows.Forms.Button cbEnterTo;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAmountOf;
        private System.Windows.Forms.Label lblFirstCurrencyCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAmountTO;
        private System.Windows.Forms.Label lblToCurrencyCode;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}