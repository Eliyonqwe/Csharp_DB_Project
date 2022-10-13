using Csharp_DB_Project.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Csharp_DB_Project
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
            btn_Register.FlatAppearance.BorderColor = Color.Orange;
            btn_back.FlatAppearance.BorderColor = Color.Orange;

        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {
            /* 
             * when register button is clicked, the program should check weather the entered   
                values are valid or not. 
             * we should also use errorprovider tool to tell user that the entered value aren't valid.
             * and when the user enters the correct information we should clear all textboxes.
            
            
        */
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            LoginPage l = new LoginPage();
            this.Hide();
            l.Show();
        }

        private void pw_click(object sender, EventArgs e)
        {
            txt_phoneno.Clear();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty( txt_firstName.Text) || String.IsNullOrEmpty( txt_lastName.Text) || String.IsNullOrEmpty(txt_uname.Text) || String.IsNullOrEmpty(txt_phoneno.Text) || String.IsNullOrEmpty(txt_password.Text) )
            { 
                MessageBox.Show("Please check your Credentials!");
            }
            else
            {
              User u = new User();
                u.firstName = txt_firstName.Text;
                u.lastName = txt_lastName.Text;
                u.username = txt_uname.Text;
                u.phoneNumber = txt_phoneno.Text;
                u.password = txt_password.Text;
                u.firstName = txt_firstName.Text;

                String conStatus = u.Save();

                if (conStatus == "0")
                    MessageBox.Show("Account crreated Succesfully!");
                else
                    MessageBox.Show(conStatus);

            }
          

        }
    }
}
