using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Util;
using System.Windows.Forms;
using BussinessLayer_BankProject;
namespace Bank_Mangment_System
{
    public partial class FormTransactionType : Form
    {
        clsTransaction Transaction=new clsTransaction();
        
        
        public FormTransactionType()
        {
            InitializeComponent();
        }

        private void pbWithdraw_Click(object sender, EventArgs e)
        {
            Transaction.TransType = clsTransaction.enTransType.WithDraw;
            FormWithdrawDeposit formTransaction = new FormWithdrawDeposit(Transaction);
            formTransaction.ShowDialog();
        }

        private void FormTransactionType_Load(object sender, EventArgs e)
        {

        }

        private void pbDeposit_Click(object sender, EventArgs e)
        {
            Transaction.TransType = clsTransaction.enTransType.Deposite;
            FormWithdrawDeposit formTransaction = new FormWithdrawDeposit(Transaction);
            formTransaction.ShowDialog();
        }

        private void pbTrans_Click(object sender, EventArgs e)
        {
            Transaction.TransType=clsTransaction.enTransType.Transaction;
            FormTrans trans = new FormTrans(Transaction);
            trans.ShowDialog();
        }

        private void pbTransLos_Click(object sender, EventArgs e)
        {
            FormTransLogs transLogs = new FormTransLogs();
            transLogs.ShowDialog();
        }
    }
}
