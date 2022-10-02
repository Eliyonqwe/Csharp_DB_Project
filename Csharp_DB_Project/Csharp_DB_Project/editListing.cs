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
    public partial class editListing : Form
    {
        String username;
        int companyID;
        int stockID;
        Company c = new Company();
        stockListing stk = new stockListing();
        int changeIndicator=0; 
        public editListing(String user)
        {
            InitializeComponent();
            username = user;
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "select *from viewListing where username = @user";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@user", username);
                    SqlDataReader result = cmd.ExecuteReader();
                    while (result.Read())
                    {
                        stk.stockID = (int)(result[0]);
                        stk.amount = (double)result[4];
                        stk.price = (double)result[5];
                        stockListing.s.Add(stk);
                        dataGridView1.DataSource = stk;
                    }

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
