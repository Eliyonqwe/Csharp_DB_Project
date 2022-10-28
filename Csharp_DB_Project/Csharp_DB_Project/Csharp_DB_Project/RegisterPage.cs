using Csharp_DB_Project.Classes;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Csharp_DB_Project
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
            btn_Register.FlatAppearance.BorderColor = Color.White;
            btn_back.FlatAppearance.BorderColor = Color.White;

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

            Regex fname_error = new Regex(@"[a-z A-Z]{" + txt_firstName.Text.Length + @"}");
            Regex number_error = new Regex(@"[0-9]{" + txt_phoneno.Text.Length + @"}");
            Regex lname_error = new Regex(@"[a-z A-Z]{" + txt_lastName.Text.Length + @"}");
            


            if ((txt_firstName.Text.Length != 0 && txt_lastName.Text.Length != 0 && txt_password.Text.Length != 0 && txt_phoneno.Text.Length != 0 && txt_uname.Text.Length != 0) && (number_error.IsMatch(txt_phoneno.Text) && fname_error.IsMatch(txt_firstName.Text) && lname_error.IsMatch(txt_lastName.Text)))

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

            else
            {

                if (string.IsNullOrEmpty(txt_firstName.Text))
                {
                    errorProvider1.SetError(txt_firstName, "please provide a Name ");

                }

                else if (fname_error.IsMatch(txt_firstName.Text) == false)
                {
                    errorProvider1.SetError(txt_firstName, "please enter a letters only ");
                }

                if (string.IsNullOrEmpty(txt_lastName.Text))
                {
                    errorProvider1.SetError(txt_lastName, "please provide a Name ");


                }
                else if (lname_error.IsMatch(txt_lastName.Text) == false)
                {
                    errorProvider1.SetError(txt_lastName, "please enter letters only ");
                }

                if (string.IsNullOrEmpty(txt_phoneno.Text))
                {
                    errorProvider1.SetError(txt_phoneno, "please provide a phone number ");


                }
                else if (number_error.IsMatch(txt_phoneno.Text) == false)
                {
                    errorProvider1.SetError(txt_phoneno, "please enter a number only ");
                }

                if (string.IsNullOrEmpty(txt_password.Text))
                {
                    errorProvider1.SetError(txt_password, "please provide a password ");


                }
                if (string.IsNullOrEmpty(txt_uname.Text))
                {
                    errorProvider1.SetError(txt_uname, "please provide a username ");


                }

            }

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files (*.jpg)|*.jpg| png files (*.png)|*.png| all files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox3.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
