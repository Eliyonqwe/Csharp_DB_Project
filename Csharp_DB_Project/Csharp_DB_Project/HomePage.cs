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
        String username = "";
        public HomePage(String user)
        {
            InitializeComponent();
            username = user;
            lb_welcome.Text += user;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int len = lb_welcome.Text.Length;
            String x = lb_welcome.Text;
            string user = x.Substring(13, len - 13); // removes welcome back from "Welcome back 'username'"

            HomePage h = new HomePage(user);
            this.Hide();
            h.Show();
        }
        
        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTImer.Start();
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
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTImer.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTImer.Stop();
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


        private void btn_addListing_Click(object sender, EventArgs e)
        {
            addListing l = new addListing(username);
            this.Hide();
            l.Show();
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
            button1.ForeColor = Color.DarkRed;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Transparent;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            editListing el = new editListing(username);
            this.Show();
            el.Show();
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
