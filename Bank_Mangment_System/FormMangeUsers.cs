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
    public partial class FormMangeUsers : FormSettings
    {
        public FormMangeUsers()
        {
            InitializeComponent();
        }

        private void FormMangeUsers_Load(object sender, EventArgs e)
        {
            Refresh();
            cbSearchBy.SelectedIndex = 0;
        }
        
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormAddEditUser formAddEditUser= new FormAddEditUser(-1);
            formAddEditUser.ShowDialog();
        }
        int FindColUserInDataGrid()
        {
            int User = 0;
            for (int i = 0; i < guna2DataGridView1.Columns.Count; i++)
            {
                if (guna2DataGridView1.Columns[i].Name == "UserID")
                {
                    User = i; break;
                }
            }
            return User;
        }
        int GetUserIDinSelectedRow()
        {
            int UserID = -1;
            int User = FindColUserInDataGrid();
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                UserID = Convert.ToInt32(guna2DataGridView1.SelectedCells[User].Value);

            }
            return UserID;
        }
        void Refresh()
        {
            guna2DataGridView1.DataSource = clsUser.GetUserData();
        }
        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = GetUserIDinSelectedRow();
            if (clsCurrentUser._CurrentUser.UserID == UserID)
            {
                MessageBox.Show("that User Is Used Cannot be Updated","Warner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormAddEditUser formAddEditUser = new FormAddEditUser(UserID);
            formAddEditUser.ShowDialog();
            Refresh();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = GetUserIDinSelectedRow();
            if (clsCurrentUser._CurrentUser.UserID == UserID)
            {
                MessageBox.Show("that User Is Used Cannot be Deleted","Warner",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (clsUser.DeleteUser(UserID))
            {
                DataGridViewRow Row = guna2DataGridView1.SelectedRows[0];
                guna2DataGridView1.Rows.Remove(Row);
                return;
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        void GetInfoByUserID(int UserID)
        {

            FormUserInfo formUserInfo = new FormUserInfo(UserID);
            formUserInfo.ShowDialog();
        }
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID=GetUserIDinSelectedRow();
            GetInfoByUserID (UserID);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)guna2DataGridView1.DataSource;
            if (dt != null)
            {
                dt.DefaultView.RowFilter = $"{cbSearchBy.Text} LIKE '%{txtSearch.Text}%'";
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
