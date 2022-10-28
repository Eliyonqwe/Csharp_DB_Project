using Csharp_DB_Project.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Csharp_DB_Project
{
    public partial class ProfilePage : Form
    {
        String username;
        int changeIndicator = 0;
        User u = new User();
        public ProfilePage(String user)
        {
            InitializeComponent();
            username = user;
            String status = u.viewUser(user);

            if (status == "0")
            {
                txt_id.Text = u.userid.ToString();
                txt_fname.Text = u.firstName;
                txt_lname.Text = u.lastName;
                txt_gender.Text = u.gender;
                txt_uname.Text = u.username;
                txt_password.Text = u.password;
                txt_phone.Text = u.phoneNumber;
                //pictureBox1.Image = ConvertToImage(u.profilePic);

                changeIndicator = 0;
            }
            else
            {
                MessageBox.Show(status);
            }
        }
        Image ConvertToImage(byte[] img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                return Image.FromStream(ms);
            }
        }
        private void btn_delete_click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete your account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                String status = u.deleteUser(Convert.ToInt32(txt_id.Text));


                if (status == "0")
                {
                    MessageBox.Show("User Has been deleted!");
                    LoginPage l = new LoginPage();
                    this.Hide();
                    l.Show();
                }
                else
                    MessageBox.Show(status);

            }



        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            Regex fname_error = new Regex(@"[a-z A-Z]{" + txt_fname.Text.Length + @"}");
            Regex number_error = new Regex(@"[0-9]{" + txt_phone.Text.Length + @"}");
            Regex lname_error = new Regex(@"[a-z A-Z]{" + txt_lname.Text.Length + @"}");

            if (changeIndicator == 0)
            {
                MessageBox.Show("Nothing has been altered/changed!");
            }

            else if ((txt_fname.Text.Length != 0 && txt_lname.Text.Length != 0 && txt_password.Text.Length != 0 && txt_phone.Text.Length != 0 && txt_uname.Text.Length != 0) && (number_error.IsMatch(txt_phone.Text) && fname_error.IsMatch(txt_fname.Text) && lname_error.IsMatch(txt_lname.Text)))

            {
                 String status = u.updateUser(Convert.ToInt32(txt_id.Text), txt_fname.Text, txt_lname.Text, txt_gender.Text, txt_uname.Text, txt_password.Text, txt_phone.Text);

                if (status == "0")
                {
                    MessageBox.Show("Change has been recorded!");
                    changeIndicator = 0;
                }
                else
                    MessageBox.Show(status);
               
            }
            else
            {

                if (string.IsNullOrEmpty(txt_fname.Text))
                {
                    errorProvider1.SetError(txt_fname, "please provide a Name ");

                }
                else if (fname_error.IsMatch(txt_fname.Text) == false)
                {
                    errorProvider1.SetError(txt_fname, "please enter a letters only ");
                }

                if (string.IsNullOrEmpty(txt_lname.Text))
                {
                    errorProvider1.SetError(txt_lname, "please provide a Name ");


                }
                else if (lname_error.IsMatch(txt_lname.Text) == false)
                {
                    errorProvider1.SetError(txt_lname, "please enter letters only ");
                }

                if (string.IsNullOrEmpty(txt_phone.Text))
                {
                    errorProvider1.SetError(txt_phone, "please provide a phone number ");


                }
                else if (number_error.IsMatch(txt_phone.Text) == false)
                {
                    errorProvider1.SetError(txt_phone, "please enter a number only ");
                }

                if (string.IsNullOrEmpty(txt_password.Text))
                {
                    errorProvider1.SetError(txt_password, "please provide a password ");


                }
                if (string.IsNullOrEmpty(txt_uname.Text))
                {
                    errorProvider1.SetError(txt_uname, "please provide a username ");


                }
                else if (txt_uname.Text == u.username)
                {
                    errorProvider1.SetError(txt_uname, "user name already exist");
                }


            }
        }



        private void txt_fname_TextChanged(object sender, EventArgs e)
        {
            changeIndicator++;
        }

        private void txt_lname_TextChanged(object sender, EventArgs e)
        {
            changeIndicator++;
        }

        private void txt_uname_TextChanged(object sender, EventArgs e)
        {
            changeIndicator++;
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            changeIndicator++;
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            changeIndicator++;
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {

        }
    }
}
