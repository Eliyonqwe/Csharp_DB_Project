using Csharp_DB_Project.Classes;
using System;
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
                txt_uname.Text = u.username;
                txt_password.Text = u.password;
                txt_phone.Text = u.phoneNumber;
                changeIndicator = 0;
            }
            else
            {
                MessageBox.Show(status);
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
            HomePage h = new HomePage(txt_uname.Text);
            this.Hide();
            h.Show();
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (changeIndicator == 0)
            {
                MessageBox.Show("Nothing has been altered/changed!");
            }
            else
            {

                String status = u.updateUser(Convert.ToInt32(txt_id.Text), txt_fname.Text, txt_lname.Text, txt_uname.Text, txt_password.Text, txt_phone.Text);

                if (status == "0")
                {
                    MessageBox.Show("Change has been recorded!");
                    changeIndicator = 0;
                }
                else
                    MessageBox.Show(status);

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

    }
}
