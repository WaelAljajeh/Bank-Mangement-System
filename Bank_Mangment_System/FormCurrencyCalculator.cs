using BussinessLayer_BankProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Mangment_System
{
    public partial class FormCurrencyCalculator : Form
    {
        clsCurrency currency1 = new clsCurrency();
        clsCurrency currency2 = new clsCurrency();
        public FormCurrencyCalculator()
        {
            InitializeComponent();
        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void nudAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(nudAmount.Value==0)
            {
                errorProvider1.SetError(btnCalculate, "Invalid Amount");
            }
            float Amount = Convert.ToSingle(nudAmount.Value);
            float Calc = currency1.CalculateCurrency(Amount, currency2);
            lblAmountOf.Text=Amount.ToString();
            lblFirstCurrencyCode.Text = currency1.Currecny_Code;
            lblAmountTO.Text=Calc.ToString();
            lblToCurrencyCode.Text=currency2.Currecny_Code;
            
        }

        private void btnEnterFrom_Click(object sender, EventArgs e)
        {
            currency1 = clsCurrency.FindCurrencyByItsCode(cbFromCurrency.Text);
            if(currency1==null)
            {
                errorProvider1.SetError(cbFromCurrency, "Not Found");
            }

        }

        private void cbEnterTo_Click(object sender, EventArgs e)
        {
            currency2 = clsCurrency.FindCurrencyByItsCode(cbToCurrency.Text);
            if (currency2 == null)
            {
                errorProvider1.SetError(cbToCurrency, "Not Found");
            }


        }

        private void FormCurrencyCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
