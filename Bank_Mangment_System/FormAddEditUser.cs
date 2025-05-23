using BussinessLayer_BankProject;
using Guna.UI2.WinForms;
using LoginSySFullProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Mangment_System
{
    public partial class FormAddEditUser : Form
    {
        clsUser User=new clsUser();
        bool IsUpdate = false;
        bool CharPass = false;
        string ImagePath = "";
        clsAnimateText animateText=new clsAnimateText();
        string[] TxtsOfFormat = {"Add New User" + Environment.NewLine + "to Bank System",
        "Welcome to"+Environment.NewLine+"Bank Mangement System" };
        public FormAddEditUser(int UserID)
        {
            InitializeComponent();
            if(UserID!=-1)
            EditMode(UserID);
        }

        private void timerAnimateLabel_Tick(object sender, EventArgs e)
        {
            bool TimerAnimatetxt = true;
            bool TimerChange = false;
            string Formatxt = "";


            animateText.Animatetxt(TxtsOfFormat, ref Formatxt, ref TimerChange, ref TimerAnimatetxt);
            lblFormattxt.Text = Formatxt;
            timerAnimateLabel.Enabled = TimerAnimatetxt;
            timerChangeLabel.Enabled = TimerChange;
        }
        bool EditMode(int UserID)
        {
            IsUpdate = true;
            if (UserID == -1)
            { return false; }
            User = clsUser.FindUserByID(UserID);
            lblUserID.Text = UserID.ToString();
            txtUsername.Text = User.Username;
            txtEmail.Text = User.Email;
            txtFirstName.Text = User.FirstName;
            txtLastName.Text = User.LastName;
            txtPassword.Text = User.Password;
            ImagePath = User.ImagePath;
            nudSalary.Value = (decimal)User.Salary;
            HidePassword(txtPassword);
            SetPermission();
            
            if (ImagePath != "")
            {
                pbRemoveImage.Visible = true;
                pbUserImage.Image = Image.FromFile(User.ImagePath);

            }
            else
            {
                pbUserImage.Image = Properties.Resources.userImage;
                pbRemoveImage.Visible = false;
            }
            return true;
        }

        private void timerChangeLabel_Tick(object sender, EventArgs e)
        {
            bool TimerAnimate = false;
            animateText.AnimateOn(ref TimerAnimate);
            timerAnimateLabel.Enabled = TimerAnimate;
        }
        void SetPermission()
        {
           if(User.Permission==-1)
           {
                cbSelectAll.Checked = true;
                return ;
           }
           if(User.CheckPermission(clsUser.enPermission.pShowClientList))
            {
                cbShowClients.Checked = true;
            }
           if(User.CheckPermission(clsUser.enPermission.PAddNewClient))
            {
                cbAddClient.Checked = true;
            }
           if(User.CheckPermission(clsUser.enPermission.PDeleteClient))
            {
                cbDeleteClient.Checked = true;
            }
           if(User.CheckPermission(clsUser.enPermission.PFindClient))
            {
                cbFindClient.Checked = true;
            }
           if(User.CheckPermission(clsUser.enPermission.PMangeUser))
            {
                cbMangeUsers.Checked = true;   
            }
            if(User.CheckPermission(clsUser.enPermission.PTrans))
            {
                cbTrans.Checked=true;
            }
            if(User.CheckPermission(clsUser.enPermission.PCurrecy))
            {
                cbCurrency.Checked=true;   
            }
            if(User.CheckPermission(clsUser.enPermission.PRegisterLogin))
            {
                cbUserLogs.Checked=true;
            }
        }
        private void FormAddEditUser_Load(object sender, EventArgs e)
        {
            
            
            timerChangeLabel.Start();
            if (!IsUpdate)
            {
                pbRemoveImage.Visible = false;
            }

        }
        int ReadPermission()
        {
            
            int Permissions = 0;
            if (cbSelectAll.Checked)
            {
                return (int)clsUser.enPermission.eAll;
            }
            else
            {
                if (cbShowClients.Checked)
                {
                    Permissions += (int)clsUser.enPermission.pShowClientList;
                }
                if(cbAddClient.Checked)
                {
                    Permissions += (int)clsUser.enPermission.PAddNewClient;
                
                }
                if(cbUpdateClient.Checked)
                {
                    Permissions += (int)clsUser.enPermission.PUpdateClient;
                }
                if(cbDeleteClient.Checked)
                {
                    Permissions += (int)clsUser.enPermission.PDeleteClient;
                }
                if(cbFindClient.Checked)
                {
                    Permissions += (int)clsUser.enPermission.PFindClient;
                }
                if(cbMangeUsers.Checked)
                {
                    Permissions += (int)clsUser.enPermission.PMangeUser;
                }
                if(cbTrans.Checked)
                {
                    Permissions += (int)clsUser.enPermission.PTrans;
                }
                if(cbCurrency.Checked)
                {
                    Permissions += (int)clsUser.enPermission.PCurrecy;

                }
                if(cbUserLogs.Checked)
                {
                    Permissions += (int)clsUser.enPermission.PRegisterLogin;
                }
            }
            return Permissions;

        }
        void AddNewUser()
        {
            
            User.FirstName=txtFirstName.Text;
            User.LastName=txtLastName.Text;
            User.Email=txtEmail.Text;
            User.Username=txtUsername.Text;
            User.Password=txtPassword.Text;
            User.Salary = Convert.ToSingle(nudSalary.Value);
            User.ImagePath = ImagePath;
            User.Permission = ReadPermission();
            if(User.Save())
            {
                MessageBox.Show("Success");
                EditMode(User.UserID);
            }
        }
        void SetImage()
        {
            openFileDialog1.ShowDialog();

        }
        private void pbCustomerImage_Click(object sender, EventArgs e)
        {
            SetImage();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pbUserImage.Image = Image.FromFile(openFileDialog1.FileName);
            ImagePath = openFileDialog1.FileName;
            pbRemoveImage.Visible = true;
        }

        private void pbRemoveImage_Click(object sender, EventArgs e)
        {
            pbRemoveImage.Visible = false;
            pbUserImage.Image = Properties.Resources.userImage;
            ImagePath = "";
        }
        bool CheckIsThereEmptyField()
        {
            if (clsValidtion.IsAllNotEmpty(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text))
            { return true; }
            else
            {
                errorProvider1.SetError(btnSave, "there Is Empty Field");
                return false;
            }
        }
        bool CheckIsEmailExisting()
        {
            return clsPerson.IsEmailExisting(txtEmail.Text)&&!IsUpdate;
        }
        bool CheckEmail()
        {

           
            bool isValid = false;
            if(CheckIsEmailExisting()&&!IsUpdate)
            {
                errorProvider1.SetError(txtEmail, "Email is already Existing");
                return false;
            }
            if (clsValidtion.CheckIsValidEmail(txtEmail.Text))
            {
                isValid = true;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "Invalid Email");
                return false;
            }
           

            return isValid;
        }
        bool CheckIsUserExisting()
        {
            if(clsUser.IsUserExisting(txtUsername.Text,txtPassword.Text)&& !IsUpdate)
            {
                errorProvider1.SetError(btnSave, "The User Already Exist");
                return true;

            }
            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(CheckIsThereEmptyField()&&CheckEmail()&&!CheckIsUserExisting())
            {
                AddNewUser();
            }
        }

        private void cbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
                foreach (Control control in panel3.Controls)
                {
                    if (control is CheckBox checkBox)
                    {

                        checkBox.Checked = cbSelectAll.Checked;
                    }

                }
            
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void ResetPassword(TextBox txtPass)
        {
            txtPass.PasswordChar = default;
            txtPass.UseSystemPasswordChar = false;
            pbEyePassword.Image = Properties.Resources.hidden;
            CharPass = false;
        }
        void HidePassword(TextBox txtPass)
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
    }
}
