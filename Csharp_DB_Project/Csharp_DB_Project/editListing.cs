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
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
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

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "select stockID, companyName, companyType, amount, price, status from viewListings where username = '" + username + "' and status = 'pending'";
                    sda = new SqlDataAdapter(sqlQuery, con);
                    dt = new DataTable();

                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    /*SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    
                    cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
                    SqlDataReader result = cmd.ExecuteReader();
                    dataGridView1.Columns.Add("stockID", "Stock ID");
                    dataGridView1.Columns.Add("companyName", "Company Name");
                    dataGridView1.Columns.Add("companyType", "Company Type");
                    dataGridView1.Columns.Add("amount", "Amount");
                    dataGridView1.Columns.Add("price", "price");
                    while (result.Read())
                    {
                        String[] data = new string[5];
                        data[0] = (result[1]).ToString();
                        data[1] = (result[3]).ToString();
                        data[2] = (result[4]).ToString();
                        data[3] = (result[5]).ToString();
                        data[4] = (result[6]).ToString();
                       
                        dataGridView1.Rows.Add(data[0], data[1], data[2], data[3], data[4]);


                    //    dataGridView1.DataSource = data;
                    */
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            c = new Company();
            String cmpnyStatus = c.deleteListing(stockID);

            s = new stockListing();
            String stkStatus = s.deleteListing(stockID);
            if (cmpnyStatus == "0" && stkStatus == "0")
            {
                MessageBox.Show("Listing has been deleted");
            }
            else
            {
                MessageBox.Show(cmpnyStatus + '\n' + stkStatus + '\n' + '\n' + stockID.ToString());
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
