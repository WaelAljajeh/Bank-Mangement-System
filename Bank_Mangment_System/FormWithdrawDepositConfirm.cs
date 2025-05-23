using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer_BankProject;

namespace Bank_Mangment_System
{
    
    public partial class FormWithdrawDepositConfirm : Form
    {
        clsTransaction Transaction = new clsTransaction();
        clsAccount FromAccount = new clsAccount();
        clsAccount ToAccount= new clsAccount();
        public FormWithdrawDepositConfirm(clsTransaction Transaction, clsAccount FromAccount, clsAccount ToAccount)
        {
            InitializeComponent();
            this.Transaction = Transaction;
            this.FromAccount = FromAccount;
            this.ToAccount = ToAccount;
        }
        void LoadTransInfo()
        {
           
            Transaction.from_AccountID = FromAccount.Account_ID;
            Transaction.To_AccountID = ToAccount.Account_ID;
            if(Transaction.TransType==clsTransaction.enTransType.WithDraw||Transaction.TransType==clsTransaction.enTransType.Transaction)
            Transaction.ClientID = FromAccount.ClientID;
            else
                Transaction.ClientID = ToAccount.ClientID;
            Transaction.UserID = clsCurrentUser._CurrentUser.UserID;
            Transaction.Amount = Convert.ToSingle(nudAmount.Value);
            Transaction.balance_after_transaction = Convert.ToSingle(FromAccount.Balance + Transaction.Amount);
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            LoadTransInfo();
            switch(Transaction.TransType)
            {
                case clsTransaction.enTransType.WithDraw:
                    if(Transaction.Withdraw(FromAccount))
                    {
                        MessageBox.Show("Success");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Faild Maybe you don't have enough money in your Account");
                    }
                    break;
                case clsTransaction.enTransType.Deposite:
                    if(Transaction.Deposit(ToAccount))
                    {
                        MessageBox.Show("Success");
                    }
                    else
                    {
                        MessageBox.Show("Faild Maybe you enter an invalid Amount");
                    }
                    return;
                case clsTransaction.enTransType.Transaction:
                    if (Transaction.Transfer(FromAccount, ToAccount))
                        MessageBox.Show("Success");
                    return;



            }
          
        }

        private void FormWithdrawDepositConfirm_Load(object sender, EventArgs e)
        {

        }
    }
}
