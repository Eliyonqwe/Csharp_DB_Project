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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Csharp_DB_Project
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            btn_login.FlatAppearance.BorderColor = Color.Orange;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String conString = @"Data Source=DESKTOP-49EQ2RG;Initial Catalog=Project;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "select *from users where username=@username and password=@password";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@username", txt_uname.Text);
                    cmd.Parameters.AddWithValue("@password", txt_passwd.Text);
                    var result = cmd.ExecuteScalar();// returns 

                    if(result == null) // there is no row with the entered username and password
                    {
                        MessageBox.Show("Invalid Credentials!");
                     //   txt_uname.Text = "Enter Username";
                       // txt_passwd.Text = "************";
                    }
                    else
                    {
                        MessageBox.Show("Login Succesfull!");
                        HomePage p = new HomePage(txt_uname.Text);
                        this.Hide();
                        p.Show();
                    }

                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }


        

        private void pswdclick(object sender, MouseEventArgs e)
        {
            txt_passwd.Clear();
        }

        private void unameclick(object sender, MouseEventArgs e)
        {
            txt_uname.Clear();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegisterPage r = new RegisterPage();
            this.Hide();
            r.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
