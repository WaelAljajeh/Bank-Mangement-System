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
//using BussinessLayer_BankProject;

namespace Bank_Mangment_System
{
    public partial class FormWithdrawDeposit : Form
    {
        clsAccount account = new clsAccount();
        clsTransaction Transaction = new clsTransaction();
        public FormWithdrawDeposit(clsTransaction transaction)
        {
            InitializeComponent();
            Transaction = transaction;
        }
        void ControlVisibilty(bool Visbile)
        {
            lblBalance.Visible = Visbile;
            label1.Visible = Visbile;
            label3.Visible = Visbile;
            llInfo.Visible = Visbile;
            btnWithdrawDeposit.Visible = Visbile;  
            
            
        }
       

        private void FormWithdrawDeposit_Load(object sender, EventArgs e)
        {
            btnWithdrawDeposit.Text = Transaction.TransType.ToString();
            ControlVisibilty(false);
            pnlAccountNotFond.Visible = false;
        }
        bool SearchForAccount()
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

        private void pbSearchAccount_Click(object sender, EventArgs e)
        {
            SearchForAccount();
       
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            FormClientInfo formClientInfo = new FormClientInfo(account.ClientID);
            formClientInfo.ShowDialog();
        }

        private void pnlAccountNotFond_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnWithdrawDeposit_Click(object sender, EventArgs e)
        {
            FormWithdrawDepositConfirm confirm;
            //clsAccount NullAccount = new clsAccount();
            if (Transaction.TransType == clsTransaction.enTransType.WithDraw)
            {
                 confirm = new FormWithdrawDepositConfirm(Transaction, account, new clsAccount());
                
            }
            else
            {
                confirm = new FormWithdrawDepositConfirm(Transaction, new clsAccount(), account);
                
            }
            confirm.ShowDialog();
            
        }

        private void llInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormClientInfo formClientInfo = new FormClientInfo(account.ClientID);
            formClientInfo.ShowDialog();
        }
    }
}
