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
    public partial class HomePage : Form
    {
        bool sidebarExpand;
        bool myListingCollapsed;
        bool myProfileCollapsed;
        bool offerCollapsed;
        bool orderCollapsed;
        String username = "";
        public HomePage(String user)
        {
            InitializeComponent();
            username = user;
            lb_welcome.Text += user;
            sidebarContainer.HorizontalScroll.Maximum = 0;
            sidebarContainer.AutoScroll = false;
            sidebarContainer.VerticalScroll.Visible = false;
            sidebarContainer.AutoScroll = true;
            sidebarContainer.VerticalScroll.Maximum = 113;
            panel3.Controls.Add(btn_logout);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage h = new HomePage(username);
            this.Hide();
            h.Show();
        }
        
        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTImer.Start();
        }
        private void btn_orders_Click(object sender, EventArgs e)
        {
            orderTimer.Start();
        }

        private void orderTimer_Tick(object sender, EventArgs e)
        {
            if (orderCollapsed)
            {
                orderContainer.Height -= 10;
                if (orderContainer.Height == orderContainer.MinimumSize.Height)
                {
                    orderCollapsed = false;
                    orderTimer.Stop();
                }
            }
            else
            {
                orderContainer.Height += 10;
                if (orderContainer.Height == orderContainer.MaximumSize.Height)
                {
                    orderCollapsed = true;
                    orderTimer.Stop();
                }
            }
        }
        private void myListingTImer_Tick(object sender, EventArgs e)
        {
            if (myListingCollapsed)
            {
                myListingContainer.Height -= 10;
                if (myListingContainer.Height == myListingContainer.MinimumSize.Height)
                {
                    myListingCollapsed = false;
                    myListingTImer.Stop();
                }
            }
            else
            {
                myListingContainer.Height += 10;
                if (myListingContainer.Height == myListingContainer.MaximumSize.Height)
                {
                    myListingCollapsed = true;
                    myListingTImer.Stop();
                }
            }

        }
        private void btn_Profile_Click(object sender, EventArgs e)
        {
            myProfileTimer.Start();
        }
       
        private void btn_myListing_Click(object sender, EventArgs e)
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
        private void sidebarTImer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarContainer.Width -= 50;
                if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTImer.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 50;
                if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTImer.Stop();
                }
            }
        }
        private void offerTimer_Tick(object sender, EventArgs e)
        {
            if (offerCollapsed)
            {
                offerContainer.Height -= 10;
                if (offerContainer.Height == offerContainer.MinimumSize.Height)
                {
                    offerCollapsed = false;
                    offerTimer.Stop();
                }
            }
            else
            {
                offerContainer.Height += 10;
                if (offerContainer.Height == offerContainer.MaximumSize.Height)
                {
                    offerCollapsed = true;
                    offerTimer.Stop();
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            offerTimer.Start();
        }
        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            ProfilePage p = new ProfilePage(username);
            panel3.Controls.Clear();
            btn_logout.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            lb_welcome.Visible = false;
            p.TopLevel = false;
            p.AutoScroll = true;
            p.Dock = DockStyle.Fill;
            p.Show();
            panel3.Controls.Add(p);

        }

        private void btn_balance_Click(object sender, EventArgs e)
        {
            addBalance b = new addBalance(username);
            panel3.Controls.Clear();
            btn_logout.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            lb_welcome.Visible = false;
            b.TopLevel = false;
            b.AutoScroll = true;
            b.Dock = DockStyle.Fill;
            b.Show();
            panel3.Controls.Add(b);
        }


        private void btn_addListing_Click(object sender, EventArgs e)
        {
            addListing l = new addListing(username);
            panel3.Controls.Clear();
            btn_logout.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            lb_welcome.Visible = false;
            l.TopLevel = false;
            l.AutoScroll = true;
            l.Dock = DockStyle.Fill;
            l.Show();
            panel3.Controls.Add(l);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

    

        private void btn_Home_MouseHover(object sender, EventArgs e)
        {
            btn_Home.ForeColor = Color.DarkRed;
        }

        private void btn_Home_MouseLeave(object sender, EventArgs e)
        {
            btn_Home.ForeColor = Color.Transparent;
        }

        private void btn_Profile_MouseHover(object sender, EventArgs e)
        {
            btn_Profile.ForeColor = Color.DarkRed;
        }

        private void btn_Profile_MouseLeave(object sender, EventArgs e)
        {
            btn_Profile.ForeColor = Color.Transparent;
        }

        private void btn_viewAllListing_MouseHover(object sender, EventArgs e)
        {
            btn_viewAllListing.ForeColor = Color.DarkRed;
        }

        private void btn_viewAllListing_MouseLeave(object sender, EventArgs e)
        {
            btn_viewAllListing.ForeColor = Color.Transparent;
        }

        private void btn_myListing_MouseHover(object sender, EventArgs e)
        {
            btn_myListing.ForeColor = Color.DarkRed;
        }

        private void btn_myListing_MouseLeave(object sender, EventArgs e)
        {
            btn_myListing.ForeColor = Color.Transparent;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.ForeColor = Color.DarkRed;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Transparent;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btn_orderSent.ForeColor = Color.DarkRed;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btn_orderSent.ForeColor = Color.Transparent;
        }
       

        private void btn_editlising_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            btn_logout.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            lb_welcome.Visible = false;
            editListing el = new editListing(username);
            el.TopLevel = false;
            el.AutoScroll = true;
            el.Dock = DockStyle.Fill;
            el.Show();
            panel3.Controls.Add(el);
        }




        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_viewAllListing_Click(object sender, EventArgs e)
        {
            /* viewListing v = new viewListing(username);
             this.Hide();
             v.Show();
 */
            panel3.Controls.Clear();
            btn_logout.Hide();
            pictureBox8.Hide();
            label3.Hide();
            label4.Hide();
            lb_welcome.Hide();
            viewListing v = new viewListing(username);
            v.TopLevel = false;
            v.AutoScroll = true;
            v.Dock = DockStyle.Fill;
            v.Show();
            panel3.Controls.Add(v);
          
        }

        private void viewOffer_Click(object sender, EventArgs e)
        {
            viewOffer v = new viewOffer(username);
            panel3.Controls.Clear();
            btn_logout.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            lb_welcome.Visible = false;
            v.TopLevel = false;
            v.AutoScroll = true;
            v.Dock = DockStyle.Fill;
            v.Show();
            panel3.Controls.Add(v);

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            btn_logout.Visible = true;
            label3.Visible=true;
            label4.Visible=true;
            lb_welcome.Visible=false;
            panel3.Controls.Add(btn_logout);
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
           
        }

        private void myListingContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OfferSent o = new OfferSent(username);
            panel3.Controls.Clear();
            btn_logout.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            lb_welcome.Visible = false;
            o.TopLevel = false;
            o.AutoScroll = true;
            o.Dock = DockStyle.Fill;
            o.Show();
            panel3.Controls.Add(o);
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            OrderPage o = new OrderPage(username);
            panel3.Controls.Clear();
            btn_logout.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            lb_welcome.Visible = false;
            o.TopLevel = false;
            o.AutoScroll = true;
            o.Dock = DockStyle.Fill;
            o.Show();
            panel3.Controls.Add(o);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecievedOrder o = new RecievedOrder(username);
            panel3.Controls.Clear();
            btn_logout.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            lb_welcome.Visible = false;
            o.TopLevel = false;
            o.AutoScroll = true;
            o.Dock = DockStyle.Fill;
            o.Show();
            panel3.Controls.Add(o);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            LoginPage l = new LoginPage();
            this.Hide();
            l.Show();
        }
    }
}