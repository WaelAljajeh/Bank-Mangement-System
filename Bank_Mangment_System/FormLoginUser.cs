using BussinessLayer_BankProject;
using Guna.UI2.WinForms;
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
    public partial class FormLoginUser : Form
    {
        bool CharPass = false;
        public FormLoginUser()
        {
            InitializeComponent();
        }

        private void FormLoginUser_Load(object sender, EventArgs e)
        {
            HidePassword(txtPassword);
            clsTrialTimer.TimeLoader(lblTryAgain,lblTimer,lblSecond,btnLogin,timerProgramStopped);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            clsCurrentUser._CurrentUser=clsUser.FindUserByUsernameandPassword(txtUsername.Text,txtPassword.Text);
            if (clsCurrentUser._CurrentUser != null)
            {
                clsUserLogs userLogs = new clsUserLogs();
                userLogs.UserID = clsCurrentUser._CurrentUser.UserID;
                userLogs.AddNewUserLogsWhenUserLoginSuccesfuly();
                FormMainMenu formMainMenu = new FormMainMenu();
                formMainMenu.ShowDialog();
            }
            else
            {
                errorProvider1.SetError(btnLogin, "Invalid Username/Password");
                clsTrialTimer.IncrementCounter(timerProgramStopped, lblTryAgain, lblTimer, lblSecond, btnLogin); ;
            }


        }
        void ResetPassword(Guna2TextBox txtPass)
        {
            txtPass.PasswordChar = default;
            txtPass.UseSystemPasswordChar = false;
            pbEyePassword.Image = Properties.Resources.hidden;
            CharPass = false;
        }
        void HidePassword(Guna2TextBox txtPass)
        { 
            txtPass.PasswordChar = '*';
            txtPass.UseSystemPasswordChar = true;

            pbEyePassword.Image = Properties.Resources.eye1;
            CharPass = true;
        }
        private void pbEyePassword_Click(object sender, EventArgs e)
        {
            if (CharPass)
                ResetPassword(txtPassword);
            else
                HidePassword(txtPassword);
        }

        private void FormLoginUser_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void timerProgramStopped_Tick(object sender, EventArgs e)
        {
            clsTrialTimer.StartTimer(lblTryAgain,lblTimer,lblSecond,btnLogin,timerProgramStopped);
        }
    }
}
