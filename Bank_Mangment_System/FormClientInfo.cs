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
    public partial class FormClientInfo : Form
    {
        int ClientID=-1;
        clsBankSystem BankSystem=new clsBankSystem();
        public FormClientInfo(int ClientID)
        {
            
            InitializeComponent();
            this.ClientID = ClientID;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        void LoadImagePic()
        {
            if(BankSystem.ImageFilePath!="")
            guna2CirclePictureBox1.Image=Image.FromFile(BankSystem.ImageFilePath);
            else
                guna2CirclePictureBox1.Image=Properties.Resources.userImage;
        }
        void LoadInfo()
        {
            lblClientID.Text=BankSystem.ClientID.ToString();
            lblFullName.Text=BankSystem.FirstName.ToString()+" "+BankSystem.LastName.ToString();
            lblAccountNumber.Text=BankSystem.AccountNumber.ToString();
            lblPIN.Text=BankSystem.PIN.ToString();
            lblEmail.Text=BankSystem.Email.ToString();
            LoadImagePic();
        }
        private void FormClientInfo_Load(object sender, EventArgs e)
        {
            BankSystem = clsBankSystem.FindInfo(ClientID);
            LoadInfo();

        }
    }
}
