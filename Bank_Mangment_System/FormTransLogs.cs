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
    public partial class FormTransLogs : Form
    {
        public FormTransLogs()
        {
            InitializeComponent();
        }

        private void FormTransLogs_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = clsTransaction.GetTransLogs();
        }

        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearchBy.Text == "All")
                return;
            DataTable dt = (DataTable)guna2DataGridView1.DataSource;
            if (dt != null)
            {
                dt.DefaultView.RowFilter = $"transaction_type='{cbSearchBy.Text}'";
            }
        }
    }
}
