using Csharp_DB_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Csharp_DB_Project
{
    public partial class RecievedOrder : Form
    {
        String username;
        int userID;
        int orderingUserID;
        int orderID;
        public RecievedOrder(String user)
        {
            InitializeComponent();
            username = user;

            User u = new User();
            u.username = user;

            String status = u.FetchID(); //fetches current user's id. It is NOT the seller's id
            if (status == "0")
            {
                userID = u.userid;
            }
            else
                MessageBox.Show(status);

            loadData();

        }
        
        private void RecievedOrder_Load(object sender, EventArgs e)
        {

        }
        private void loadData()
        {
            Order o = new Order();
            String status = o.viewRecievedOrders(dataGridView1, userID);
            if (status != "0")
            {
                MessageBox.Show(status);
            }
            else
            {
                if (dataGridView1.Rows.Count == 0)
                    MessageBox.Show("There are no orders to show!");
            }

        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You can't revert deleting the order! \n\nAre you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Order o = new Order();
                String status = o.cancelOrder(orderID, userID, orderingUserID);
                if (status == "0")
                {
                    MessageBox.Show("Order Deleted!");
                    loadData();
                }
                else
                    MessageBox.Show(status);
            
            }
            else
            {
                ;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderingUserID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txt_companyName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_companyType.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_amount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_orderingPrice.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            orderID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString());
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            String status = o.searchrecievedOrder(dataGridView1, search_txt.Text, userID);
            if (status != "0")
                MessageBox.Show(status);
            else
            {

                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No offer found with '" + search_txt.Text + "' Keyword!");
                }
            }
        }

        private void search_txt_Click(object sender, EventArgs e)
        {
            search_txt.Clear();
            search_txt.ForeColor = Color.Black;
        }
    }
}
