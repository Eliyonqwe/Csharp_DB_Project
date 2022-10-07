using Csharp_DB_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_DB_Project
{
    public partial class viewListing : Form
    {
        String username;
        stockListing s;
        int userID;
        public viewListing(String user)
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

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "select *from viewAllListing where not userID = '"+userID+"' and status = 'pending'";
                    SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, con);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_userID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_stockID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_cname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_ctype.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_amount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_price.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            
        }

        private void btn_offer_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Error: Please select a listing before offering!");
            }
            else
            {
                Offer o = new Offer();
                o.offeringuserID = userID;
                o.sellerID = Convert.ToInt32(txt_userID.Text);
                o.stockID = Convert.ToInt32(txt_stockID.Text);
                o.offerAmount = Convert.ToDouble(txt_offerPrice.Text);
                string status = o.addOffer();
                if(status == "0")
                    MessageBox.Show("success");
                else
                    MessageBox.Show(status);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage h = new HomePage(username);
            this.Hide();
            h.Show();

        }

        private void viewListing_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
