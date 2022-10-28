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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            btn_login.FlatAppearance.BorderColor = Color.White;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pswdclick(object sender, EventArgs e)
        {
            txt_passwd.Clear();
        }

        private void uname_click(object sender, EventArgs e)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txt_passwd.PasswordChar == '*')
            {
                txt_passwd.PasswordChar = '\0';
                //pictureBox3.BackgroundImage =
            }
            else
            {
                txt_passwd.PasswordChar = '*';
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            User u = new User();
            string status = u.checkuser(txt_uname.Text, txt_passwd.Text);
            
            if(status == "1")
            {
                MessageBox.Show("Invalid Credentials");
            }
            else if(status == "2")
            {
                MessageBox.Show("Welcome Back!");
                HomePage h = new HomePage(txt_uname.Text);
                this.Hide();
                h.Show();

            }
            else
            {
                MessageBox.Show(status);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_adminPage_Click(object sender, EventArgs e)
        {
            AdminLoginPage a = new AdminLoginPage();
            this.Hide();
            a.Show();
             
             
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
