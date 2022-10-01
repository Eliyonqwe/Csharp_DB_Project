using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Csharp_DB_Project.Classes;

namespace Csharp_DB_Project
{
    public partial class addListing : Form
    {
        int userID;
        String username;

        public addListing(String username)
        {
            InitializeComponent();
            this.username = username;
            User u = new User();
            u.username = username;
           
            String status = u.FetchID();
            if (status == "0")
            {
                userID = u.userid;
            } 
            else
                MessageBox.Show(status);
            

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Company c = new Company();
            c.companyName = txt_companyName.Text;
            c.companyType = txt_companyType.Text;
            String companyStatus = c.addCompany();
            

            stockListing s = new stockListing();
            s.companyID = Convert.ToInt32(c.companyID);
            s.userID = userID;
            s.amount = Convert.ToDouble(txt_amount.Text);
            s.price = Convert.ToDouble(txt_price.Text);
           
            String stockStatus = s.addListing();

            if(companyStatus == "0" && stockStatus == "0")
            {
                MessageBox.Show("Listing has been added");
            }
            else
            {
                MessageBox.Show(companyStatus + '\n' + stockStatus+  '\n' + '\n' + s.companyID.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_amount.Clear();
            txt_companyName.Clear();
            txt_companyType.Clear();
            txt_price.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomePage h = new HomePage(username);
            this.Hide();
            h.Show();
        }

        private void addListing_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
