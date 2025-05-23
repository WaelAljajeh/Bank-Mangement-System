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
    public partial class FormShowCurreciesList : Form
    {
        public FormShowCurreciesList()
        {
            InitializeComponent();
        }

        private void FormShowCurreciesList_Load(object sender, EventArgs e)
        {
            cbSearchBy.SelectedItem = cbSearchBy.Items[0];
            guna2DataGridView1.DataSource=clsCurrency.GetAllCurrencies();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)guna2DataGridView1.DataSource;
            if (dt != null)
            {
                dt.DefaultView.RowFilter = $"{cbSearchBy.Text} LIKE '%{txtSearch.Text}%'";
            }
        }

        private void btnCalcCurrency_Click(object sender, EventArgs e)
        {
            FormCurrencyCalculator calc = new FormCurrencyCalculator();
            calc.ShowDialog();
        }
    }
}
