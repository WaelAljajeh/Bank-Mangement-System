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
    public partial class FormCusomers : FormSettings
    {
        public FormCusomers()
        {
            InitializeComponent();
        }

   

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormCusomers_Load(object sender, EventArgs e)
        {
            Refresh();
            cbSearchBy.SelectedIndex = 0;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)guna2DataGridView1.DataSource;
            if (dt != null)
            {
                dt.DefaultView.RowFilter = $"{cbSearchBy.Text} LIKE '%{txtSearch.Text}%'";
            }
        }

        private void pbAddCustomer_Click(object sender, EventArgs e)
        {
            FormAddAccount formAddAccount = new FormAddAccount(-1);
            formAddAccount.ShowDialog ();
            Refresh();
        }

        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cbSearchBy.Text!="")
            {
                txtSearch.PlaceholderText = cbSearchBy.Text;
            }
        }
        int FindColClientInDataGrid()
        {
            int Client = 0;
            for (int i = 0; i < guna2DataGridView1.Columns.Count; i++)
            {
                if (guna2DataGridView1.Columns[i].Name == "ClientID")
                {
                    Client = i; break;
                }
            }
            return Client;
        }
        int GetClientIDinSelectedRow()
        {
            int ClientID = -1;
            int Client = FindColClientInDataGrid();
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                ClientID = Convert.ToInt32(guna2DataGridView1.SelectedCells[Client].Value);

            }
            return ClientID;
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
      
            int ClientID = GetClientIDinSelectedRow();
            
            FormAddAccount formAddAccount=new FormAddAccount(ClientID);
            formAddAccount.ShowDialog();
                Refresh();
            
            

        }
        void GetInfoByClientID(int ClientID)
        {
            
            FormClientInfo formClientInfo = new FormClientInfo(ClientID);
            formClientInfo.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
               int ClientID =GetClientIDinSelectedRow();
                if(clsBankSystem.DeleteClientAccount(ClientID))
                {
                    DataGridViewRow Row = guna2DataGridView1.SelectedRows[0];
                    guna2DataGridView1.Rows.Remove(Row);
                    return;
                }
            
        }
        void Refresh()
        {
            guna2DataGridView1.DataSource = clsBankSystem.GetData();
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Refresh();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ClientID = GetClientIDinSelectedRow();
            GetInfoByClientID(ClientID);
        }
    }
}
