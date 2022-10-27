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
       
        int userID;
        User u;
        public viewListing(String user)
        {
            InitializeComponent();
            username = user;
            
             u = new User();
            u.username = user;

            String status = u.FetchID(); //fetches current user's id. It is NOT the seller's id
            if (status == "0")
            {
                userID = u.userid;
            }
            else
                MessageBox.Show(status);

        }

      /*  private void btn_load_Click(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* txt_userID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_stockID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_cname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_ctype.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_amount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_price.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
*/
            
        }

        private void btn_offer_Click(object sender, EventArgs e)
        {
            /* if(dataGridView1.SelectedCells.Count == 0)
             {
                 MessageBox.Show("Error: Please select a listing before offering!");
             }*/
            if (MessageBox.Show("If your offer gets accepted you cannot get a refund! \n\nAre you sure you want to offer?", "Offer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

            {
                if (String.IsNullOrEmpty(txt_stockID.Text) || String.IsNullOrEmpty(txt_userID.Text) || String.IsNullOrEmpty(txt_offerPrice.Text))
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
                    if (status == "0")
                        MessageBox.Show("Offer has been sent successfuly!");
                    else
                        MessageBox.Show(status);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void viewListing_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void displayLsitings1_Load(object sender, EventArgs e)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();
                string sqlQuery = "select *from viewAllListing where not userID = '" + userID + "' and status = 'pending' ";
              
                SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, con);
                DataTable dt = new DataTable();


                if (con.State == System.Data.ConnectionState.Open)
                {
                    sda.Fill(dt);
                }

                int i = 0;
                
               
                display_panel.Controls.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    displayLsitingsControl ds = new displayLsitingsControl(u.username);
                    ds.userid = dt.Rows[i][0].ToString();
                    ds.stockid = dt.Rows[i][1].ToString();
                    ds.companyname = dt.Rows[i][2].ToString();
                    ds.companytype = dt.Rows[i][3].ToString();
                    ds.amount = dt.Rows[i][4].ToString();
                    ds.sellingprice = dt.Rows[i][5].ToString();

                    ds.Click += (object o, EventArgs e2) =>
                    {
                       txt_userID.Text = ds.userid.ToString();
                        txt_stockID.Text = ds.stockid.ToString();
                        txt_cname.Text =ds.companyname.ToString();
                        txt_ctype.Text = ds.companytype.ToString();
                        txt_amount.Text = ds.amount.ToString();
                        txt_price.Text = ds.sellingprice.ToString();
                    };

                        i++;
                    display_panel.Controls.Add(ds);
                    
                } 
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void display_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();
                // string sqlQuery = "select *from viewAllListing where not userID = '" + userID + "' and status = 'pending'";
                string sqlQuery = "exec searchListings '" + search_txt.Text + "','" + userID + "' ";

                SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, con);
                DataTable dt = new DataTable();


                if (con.State == System.Data.ConnectionState.Open)
                {
                    sda.Fill(dt);
                }

                int i = 0;


                display_panel.Controls.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    displayLsitingsControl ds = new displayLsitingsControl(u.username);
                    ds.userid = dt.Rows[i][0].ToString();
                    ds.stockid = dt.Rows[i][1].ToString();
                    ds.companyname = dt.Rows[i][2].ToString();
                    ds.companytype = dt.Rows[i][3].ToString();
                    ds.amount = dt.Rows[i][4].ToString();
                    ds.sellingprice = dt.Rows[i][5].ToString();

                    ds.Click += (object o, EventArgs e2) =>
                    {
                        txt_userID.Text = ds.userid.ToString();
                        txt_stockID.Text = ds.stockid.ToString();
                        txt_cname.Text = ds.companyname.ToString();
                        txt_ctype.Text = ds.companytype.ToString();
                        txt_amount.Text = ds.amount.ToString();
                        txt_price.Text = ds.sellingprice.ToString();
                    };

                    i++;
                    display_panel.Controls.Add(ds);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void search_txt_Click(object sender, EventArgs e)
        {
            search_txt.Clear();
            search_txt.ForeColor = Color.Black;
        }
    }
 }

