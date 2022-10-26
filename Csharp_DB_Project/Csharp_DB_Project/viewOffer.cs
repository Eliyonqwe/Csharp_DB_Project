using Csharp_DB_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Csharp_DB_Project
{
    public partial class viewOffer : Form
    {
        String username;
        int userID;
        int offerID;
        int sellerUserID;
        int orderingUserID;
        int stockID;
        public viewOffer(String user)
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

        private void btn_load_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void loadData()
        {
            Offer o = new Offer();
            String status = o.viewOffer(dataGridView1, userID);

            if (status != "0")
                MessageBox.Show(status);
            else
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("There are no pending offers to show!");
                }
            }
        }
        private void btn_accept_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.selleruserID = sellerUserID;
            o.orderingUserID = orderingUserID;
            o.stockID = stockID;
            o.orderAmount = Convert.ToDouble(txt_offeramount.Text);
            String status = o.addOrder(offerID);
            if (status == "0")
            {
                MessageBox.Show(" Offer has been accepeted!");
                loadData();
            }
            else
                MessageBox.Show(status);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            offerID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
            orderingUserID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value);
            sellerUserID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value);
            stockID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value);

            txt_companyName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_companyType.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_amount.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_price.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_offeramount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        
        }

        private void viewOffer_Load(object sender, EventArgs e)
        {
          
        }

        private void search_txt_Click(object sender, EventArgs e)
        {
            search_txt.Clear();
            search_txt.ForeColor = Color.Black;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            Offer o = new Offer();
            string status = o.searchRecievedOffer(dataGridView1, userID, search_txt.Text);
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
    }
}
