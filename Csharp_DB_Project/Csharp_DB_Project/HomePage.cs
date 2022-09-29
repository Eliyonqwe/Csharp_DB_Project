﻿using System;
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
        public HomePage(String user)
        {
            InitializeComponent();
            lb_welcome.Text = "Welcome back " + user;
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
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int len = lb_welcome.Text.Length;
            String x = lb_welcome.Text;
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
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

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
    }
}
