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

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "select *from viewOffers where sellerUserID = '" + userID + "' and offerstatus = 'pending'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage h = new HomePage(username);
            this.Hide();
            h.Show();
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
                MessageBox.Show(" Offer has been accepeted!");
            else
                MessageBox.Show(status);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_companyName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_companyType.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_amount.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_price.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_offeramount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            offerID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
            orderingUserID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value);
            sellerUserID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value);
            stockID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value);

        }

        private void viewOffer_Load(object sender, EventArgs e)
        {

        }
    }
}
