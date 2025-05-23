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
    public partial class FormAddAccount : Form
    {
        clsAnimateText animateText=new clsAnimateText();
        string ImagePath = "";
        bool IsUpdate = false;  
        string[] TxtsOfFormat = {"Create Your Account" + Environment.NewLine + "It's Free",
        "Welcome to"+Environment.NewLine+"Bank Mangement System" };
        clsBankSystem BankSystem = new clsBankSystem();
        public FormAddAccount(int ClientID)
        {
            
            InitializeComponent();
            if (ClientID != -1)
            {
                EditMode(ClientID);
            }
        }
        bool EditMode(int ClientID)
        {
            IsUpdate = true;
            if (ClientID == -1)
            { return false; }
            BankSystem = clsBankSystem.FindInfo(ClientID);
            lblCustomerID.Text=ClientID.ToString();
            txtAccountNumber.Text = BankSystem.AccountNumber;
            txtEmail.Text = BankSystem.Email;
            txtFirstName.Text = BankSystem.FirstName;
            txtLastName.Text = BankSystem.LastName;
            txtPin.Text = BankSystem.PIN;
            ImagePath = BankSystem.ImageFilePath;
            if (ImagePath!="")
            {
                pbRemoveImage.Visible = true;
                pbCustomerImage.Image = Image.FromFile(BankSystem.ImageFilePath);
                
            }
            else
            {
                pbCustomerImage.Image = Properties.Resources.userImage;
                pbRemoveImage.Visible = false;
            }
            return true;
        }
        int FindEmail()
        {
            int PersonID = -1;
            PersonID=clsPerson.GetIDByPersonInfo(txtEmail.Text,txtFirstName.Text,txtLastName.Text);
            if (clsValidtion.CheckIsEmailExisting(txtEmail.Text)&&PersonID==-1)
            {

                errorProvider1.SetError(txtEmail, "Email Already Existing");
              
            }
            return PersonID;
        }
        bool CheckEmail()
        {
            bool isValid = false ;
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
        void AddClient()
        {
            
            BankSystem.FirstName = txtFirstName.Text;
            BankSystem.LastName = txtLastName.Text;
            BankSystem.Email = txtEmail.Text;
            BankSystem.AccountNumber = txtAccountNumber.Text;
            BankSystem.PIN=txtPin.Text;
            BankSystem.ImageFilePath = ImagePath;
            BankSystem.PersonID = FindEmail();
            
            if(BankSystem.Save())
            {
                EditMode(BankSystem.ClientID);
                //lblCustomerID.Text = bankSystem.ClientID.ToString();
                MessageBox.Show("Success");
                
            }
        }
        bool CheckAccountNumber()
        {
            if (clsValidtion.CheckIfAccountNumberExisting(txtAccountNumber.Text)&&!IsUpdate)
            {
                errorProvider1.SetError(txtAccountNumber, "Account_Number already Existing");
                return false;
            }
            if (clsValidtion.CheckAccountNumber(txtAccountNumber.Text))
            { return true; }
            else
            {
                errorProvider1.SetError(txtAccountNumber, "Invalid Account_Number");
                return false;
            }
            
        }
        bool CheckPINCode()
        {
            if(clsValidtion.CheckPINCode(txtPin.Text))
                { return true; }
            else
            {
                errorProvider1.SetError(txtPin, "Invalid PIN_Code");
                return false;
            }
        }
        bool CheckIsThereEmptyField()
        {
            if(clsValidtion.IsAllNotEmpty(txtFirstName.Text, txtLastName.Text,txtEmail.Text,txtAccountNumber.Text,txtPin.Text))
            { return true; }
            else
            {
                errorProvider1.SetError(btnSave, "there Is Empty Field");
                return false;
            }
        }
    
        private void FormAddAccount_Load(object sender, EventArgs e)
        {
            
            timerChangeLabel.Start();
             if(!IsUpdate)
             {
                pbRemoveImage.Visible = false;
             }
        }

        private void timerAnimateLabel_Tick(object sender, EventArgs e)
        {
            bool TimerAnimatetxt = true;
            bool TimerChange = false;
            string Formatxt = "";
            

            animateText.Animatetxt(TxtsOfFormat,ref Formatxt, ref TimerChange, ref TimerAnimatetxt);
            lblFormattxt.Text=Formatxt;
            timerAnimateLabel.Enabled = TimerAnimatetxt;
            timerChangeLabel.Enabled= TimerChange;
           // Animatetxt();
        }
        private void timerChangeLabel_Tick(object sender, EventArgs e)
        {
            bool TimerAnimate = false;
            animateText.AnimateOn(ref TimerAnimate);
            timerAnimateLabel.Enabled= TimerAnimate;
            //AnimateOn();  
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckIsThereEmptyField() && CheckPINCode() && CheckEmail() && CheckAccountNumber())
            {
                AddClient();
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void SetImage()
        {
            openFileDialog1.ShowDialog();
            
        }

       

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pbCustomerImage.Image = Image.FromFile(openFileDialog1.FileName);
            ImagePath = openFileDialog1.FileName;
            pbRemoveImage.Visible = true;
            
        }

       

        private void pbRemoveImage_Click(object sender, EventArgs e)
        {
            pbRemoveImage.Visible = false;
            pbCustomerImage.Image=Properties.Resources.userImage;
            ImagePath = "";
        }

        private void pbCustomerImage_Click(object sender, EventArgs e)
        {
            SetImage();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
