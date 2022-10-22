using Csharp_DB_Project.Admin;
using Csharp_DB_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            panel3.Controls.Clear();
            viewUser v = new viewUser();
            v.Show();
            v.TopLevel = false;
            v.AutoScroll = true;
            v.Dock = DockStyle.Fill;
            v.Show();
            panel3.Controls.Add(v);
        }

        private void btn_viewAllListing_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            viewListings v = new viewListings();
            v.Show();
            v.TopLevel = false;
            v.AutoScroll = true;
            v.Dock = DockStyle.Fill;
            v.Show();
            panel3.Controls.Add(v);

        }

        private void myProfileContainer_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void btn_offer_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            viewOffers o = new viewOffers();
            o.Show();
            o.TopLevel = false;
            o.AutoScroll = true;
            o.Dock = DockStyle.Fill;
            o.Show();
            panel3.Controls.Add(o);


        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            viewOrders o = new viewOrders();
            o.Show();
            o.TopLevel = false;
            o.AutoScroll = true;
            o.Dock = DockStyle.Fill;
            o.Show();
            panel3.Controls.Add(o);
        }
    }
}
