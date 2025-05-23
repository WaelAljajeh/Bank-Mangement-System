using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BussinessLayer_BankProject;
namespace Bank_Mangment_System
{
    public partial class FormUserInfo : Form
    {
        int UserID = -1;
        clsUser User = new clsUser();
        public FormUserInfo(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
        }
        void LoadImagePic()
        {
            if (User.ImagePath != "")
                guna2CirclePictureBox1.Image = Image.FromFile(User.ImagePath);
            else
                guna2CirclePictureBox1.Image = Properties.Resources.userImage;
        }
        void LoadInfo()
        {
            lblUserID.Text = User.UserID.ToString();
            lblFullName.Text = User.FirstName.ToString() + " " + User.LastName.ToString();
            lblUsername.Text = User.Username.ToString();
            lblPassword.Text = User.Password.ToString();
            lblEmail.Text = User.Email.ToString();
            lblSalary.Text=User.Salary.ToString();
            LoadImagePic();
        }
        private void FormUserInfo_Load(object sender, EventArgs e)
        {
            User=clsUser.FindUserByID(UserID);
            LoadInfo();
        }
    }
}
