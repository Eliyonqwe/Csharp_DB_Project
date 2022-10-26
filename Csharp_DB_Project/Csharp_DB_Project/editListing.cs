using Csharp_DB_Project.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Csharp_DB_Project
{
    public partial class editListing : Form
    {
        String username;
        int userID;
        int companyID;
        int stockID;
        Company c;
        stockListing s;
        stockListing stk = new stockListing();
        int changeIndicator = 0;
        public editListing(String user)
        {
            InitializeComponent();
            username = user;
            User u = new User();
            u.username = user;

            String status = u.FetchID();
            if (status == "0")
            {
                userID = u.userid;
            }
            else
                MessageBox.Show(status);
            loadData();


        }
     
        private void btn_update_Click(object sender, EventArgs e)
        {
            c = new Company();
            String cmpnyStatus = c.updateListing(stockID, txt_companyName.Text, txt_companyType.Text);

            s = new stockListing();
            String stkStatus = s.updateListing(stockID, Convert.ToDouble(txt_amount.Text), Convert.ToDouble(txt_price.Text));
            if (cmpnyStatus == "0" && stkStatus == "0")
            {
                MessageBox.Show("Listing has been edited");
                loadData();
            }
            else
            {
                MessageBox.Show(cmpnyStatus + '\n' + stkStatus + '\n' + '\n' + stockID.ToString());
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             stockID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            txt_companyName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_companyType.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_amount.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_price.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void loadData() 
        {
            stockListing s = new stockListing();
            String status = s.viewListingData(dataGridView1, username);


            if (status != "0")
                MessageBox.Show(status);
            else
            {
                changeIndicator = 0;
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("There are no pending offers to show!");
                }
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                s = new stockListing();
                String stkStatus = s.deleteListing(stockID);
                c = new Company();
                String cmpnyStatus = c.deleteListing(stockID);


                if (cmpnyStatus == "0" && stkStatus == "0")
                {
                    MessageBox.Show("Listing has been deleted");
                    loadData();
                }
                else
                {
                    MessageBox.Show(cmpnyStatus + '\n' + stkStatus + '\n' + '\n' + stockID.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void editListing_Load(object sender, EventArgs e)
        {

        }
    }
}
