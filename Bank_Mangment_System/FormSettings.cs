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
    public partial class FormSettings : Form
    {
        bool IsCliked = false;
        public FormSettings()
        {
            InitializeComponent();
        }

   

      

        private void FormSettings_Load(object sender, EventArgs e)
        {
            if(clsCurrentUser._CurrentUser.ImagePath!="")
            pbImg.Image = Image.FromFile(clsCurrentUser._CurrentUser.ImagePath);
            pnlSettings.Visible = false;
            lblNameSettingsUser.Text = clsCurrentUser._CurrentUser.Username;
        }

        private void lblNameSettingsUser_Click(object sender, EventArgs e)
        {

        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void lblShowLogs_Click(object sender, EventArgs e)
        {
            if (clsCurrentUser._CurrentUser.CheckPermission(clsUser.enPermission.PRegisterLogin))
            {
                FormUserLogs userLogs = new FormUserLogs();
                userLogs.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Have No Permmsion");
            }
        }

        private void pbSettings_Click(object sender, EventArgs e)
        {
            if (!IsCliked)
            {
                pnlSettings.Visible = true;
                IsCliked = true;
            }
            else
            {
                pnlSettings.Visible = false;
                IsCliked = false;

            }
        }
    }
}
