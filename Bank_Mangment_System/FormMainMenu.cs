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
    public partial class FormMainMenu :FormSettings
    {
        //clsUser User=new clsUser();
        public FormMainMenu()
        {
            InitializeComponent();
            panel1.SendToBack();
            panel6.SendToBack();
            lblSalaries.SendToBack();
            panel8.SendToBack();
            
           // this.User = User;
        }
        void LoadInfoToCards()
        {
            lblCustomersCount.Text = clsClient.GetCountOfClients().ToString();
            lblUsersCount.Text = clsUser.GetUserCount().ToString();
            lblSalaries.Text = clsUser.GetAllSalaries().ToString();
            lblBalancesSum.Text=clsAccount.GetSumOfBalances().ToString();
            lblDepositCounter.Text = clsTransaction.GetTransactionCountPerDays(DateTime.Now.Day, clsTransaction.enTransType.Deposite.ToString()).ToString();
            lblWithdrawCounter.Text = clsTransaction.GetTransactionCountPerDays(DateTime.Now.Day, clsTransaction.enTransType.WithDraw.ToString()).ToString();
            lblTransfer.Text = clsTransaction.GetTransactionCountPerDays(DateTime.Now.Day, clsTransaction.enTransType.Transaction.ToString()).ToString();
            lblLogsCounter.Text=clsUserLogs.GetHowManyUsersLogin().ToString();
        }


        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            LoadInfoToCards();
            

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void pbCustomers_Click(object sender, EventArgs e)
        {
            

        }

        private void pbCustomers_Click_1(object sender, EventArgs e)
        {
            if (clsCurrentUser._CurrentUser.CheckPermission(clsUser.enPermission.pShowClientList))
            {
                FormCusomers formCusomers = new FormCusomers();

                formCusomers.Show();
                LoadInfoToCards();


            }
            else
            {
                MessageBox.Show("You Have No Permmsion");
            }





        }

        private void pbDashboard_Click(object sender, EventArgs e)
        {
           

        }

        private void pbUserScreen_Click(object sender, EventArgs e)
        {
            if (clsCurrentUser._CurrentUser.CheckPermission(clsUser.enPermission.PMangeUser))
            {
                FormMangeUsers mangeUsers = new FormMangeUsers();
                mangeUsers.ShowDialog();
                LoadInfoToCards();
            }
            else
            {
                MessageBox.Show("You have no Permission", "No Permission", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            //FormAddEditUser formAddEditUser = new FormAddEditUser();
            //formAddEditUser.ShowDialog();
        }

        private void pbTransactionTypes_Click(object sender, EventArgs e)
        {
            if (clsCurrentUser._CurrentUser.CheckPermission(clsUser.enPermission.PTrans))
            {
                FormTransactionType formTransactionTypes = new FormTransactionType();
                formTransactionTypes.ShowDialog();
                LoadInfoToCards();
            }
            else
            {
                MessageBox.Show("You Have No Permmsion");
            }
        }

        private void pbShowCurrencies_Click(object sender, EventArgs e)
        {
            if (clsCurrentUser._CurrentUser.CheckPermission(clsUser.enPermission.PCurrecy))
            {
                FormShowCurreciesList formShowCurreciesList = new FormShowCurreciesList();
                formShowCurreciesList.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Have No Permmsion");
            }
        }
    }
}
