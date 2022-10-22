using Csharp_DB_Project.Admin;
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

namespace Csharp_DB_Project
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            viewUser v = new viewUser();
            this.Hide();
            v.Show();
            
        }

        private void btn_viewAllListing_Click(object sender, EventArgs e)
        {
            viewListings v = new viewListings();
            this.Hide();
            v.Show();
           
        }

        private void myProfileContainer_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void btn_offer_Click(object sender, EventArgs e)
        {
            viewOffers o = new viewOffers();
            this.Hide();
            o.Show();

        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            viewOrders o = new viewOrders();
            this.Hide();
            o.Show();
        }
    }
}
