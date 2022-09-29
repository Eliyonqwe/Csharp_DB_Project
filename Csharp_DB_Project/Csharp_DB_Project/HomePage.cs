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
    public partial class HomePage : Form
    {
        bool sidebarExpand;
        bool myListingCollapsed;
        bool myProfileCollapsed;
        String username = "";
        public HomePage(String user)
        {
            InitializeComponent();
            username = user;    
            lb_Welcome.Text = "Welcome back " + user;
        }

        void filltab()
        {
            int count = 0;
            try
            {
                String conString = @"Data Source=DESKTOP-49EQ2RG;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "select *from tournament";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    var result = cmd.ExecuteReader(); // returns row affected, executescalar for single element(preferebally a row)    
                    while (result.Read())
                    {
                        string tName = result.GetString(1);
                        count++;
                        //SelectTournament.Items.Add(tName);
                    }
                    
                }   

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int len = lb_Welcome.Text.Length;
            String x = lb_Welcome.Text;
            string user = x.Substring(13, len-13); // removes welcome back from "Welcome back 'username'"

            HomePage h = new HomePage(user);
            this.Hide();
            h.Show();
        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarContainer.Width -= 10;
                if(sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTImer.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if(sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTImer.Stop();
                }
            }
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTImer.Start();
        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            myProfileTimer.Start();
        }

        

        private void myListingContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void myListingTImer_Tick(object sender, EventArgs e)
        {
            if (myListingCollapsed)
            {
                myListingContainer.Height -= 10;
                if(myListingContainer.Height == myListingContainer.MinimumSize.Height)
                {
                    myListingCollapsed = false;
                    myListingTImer.Stop();
                }
            }
            else
            {
                myListingContainer.Height += 10;
                if(myListingContainer.Height == myListingContainer.MaximumSize.Height)
                {
                    myListingCollapsed = true;
                    myListingTImer.Stop();
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            myListingTImer.Start();
        }

        private void myProfileTimer_Tick(object sender, EventArgs e)
        {
            if (myProfileCollapsed)
            {
                myProfileContainer.Height -= 10;
                if (myProfileContainer.Height == myProfileContainer.MinimumSize.Height)
                {
                    myProfileCollapsed = false;
                    myProfileTimer.Stop();
                }
            }
            else
            {
                myProfileContainer.Height += 10;
                if (myProfileContainer.Height == myProfileContainer.MaximumSize.Height)
                {
                    myProfileCollapsed = true;
                    myProfileTimer.Stop();
                }
            }


        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            ProfilePage p = new ProfilePage(username);
            this.Hide();
            p.Show();
              
        }

        private void btn_balance_Click(object sender, EventArgs e)
        {
            addBalance b = new addBalance(username);
            this.Hide();
            b.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
