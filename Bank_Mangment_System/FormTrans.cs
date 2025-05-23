using BussinessLayer_BankProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web.Util;
using System.Windows.Forms;

namespace Bank_Mangment_System
{
    public partial class FormTrans : Form
    {
        clsAccount SenderAccount = new clsAccount();
        clsAccount ReciverAccount= new clsAccount();
        clsTransaction Transaction = new clsTransaction();
        bool IsInReciverAccount = false;
        //clsTransaction Transaction=new clsTransaction();
        public FormTrans(clsTransaction transaction)
        {
            InitializeComponent();
            Transaction = transaction;
        }
        void ResetAll()
        {
            ControlVisibilty(false);
            pnlAccountNotFond.Visible = false;
            lblBalance.Text = string.Empty;
            guna2TextBox1.Text = string.Empty;
        }
        void ControlVisibilty(bool Visbile)
        {
            lblBalance.Visible = Visbile;
            label1.Visible = Visbile;
            label3.Visible = Visbile;
            llInfo.Visible = Visbile;
            btnTrans.Visible = Visbile;


        }
        bool SearchForAccount(ref clsAccount account)
        {
            account = clsAccount.GetBalanceAndIDByNumber(guna2TextBox1.Text);
            if (account != null)
            {
                ControlVisibilty(true);
                pnlAccountNotFond.Visible = false;
                lblBalance.Text = account.Balance.ToString();
                return true;
            }
            else
            {
                ControlVisibilty(false);
                pnlAccountNotFond.Visible = true;
                return false;
            }
        }

        private void FormTrans_Load(object sender, EventArgs e)
        {
            Transaction.TransType = clsTransaction.enTransType.Transaction;
            ResetAll();
        }
        void GetInfo(clsAccount account)
        {
            FormClientInfo formClientInfo = new FormClientInfo(account.ClientID);
            formClientInfo.ShowDialog();
        }
        private void llInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (IsInReciverAccount)
                GetInfo(ReciverAccount);
            else
                GetInfo(SenderAccount);
        }
        private void pbSearchAccount_Click(object sender, EventArgs e)
        {
           


        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            if(SenderAccount==ReciverAccount)
            {
                MessageBox.Show("Invalid Account");
                return;
            }
            if(IsInReciverAccount)
            {
                FormWithdrawDepositConfirm confirm = new FormWithdrawDepositConfirm(Transaction, SenderAccount, ReciverAccount);
                confirm.ShowDialog();
                return;
            }
            ResetAll();
            btnTrans.Text = "Transaction"; 
            IsInReciverAccount = true;
        }

        private void pbSearchAccount_Click_1(object sender, EventArgs e)
        {
            if (IsInReciverAccount)
                SearchForAccount(ref ReciverAccount);
            else
                SearchForAccount(ref SenderAccount);
        }
    }
}
