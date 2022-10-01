using Csharp_DB_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Csharp_DB_Project
{
    public partial class addBalance : Form
    {
        String username;
        int changeIndicator = 0;
        User u = new User();
        public addBalance(String user)
        {
            InitializeComponent();
            username = user;
            String status = u.viewUser(user);
            if (status == "0")
            {
                txt_balance.Text = u.balance.ToString();
                changeIndicator = 0;
            }
            else
            {
                MessageBox.Show(status);
            }
        }

        private void txt_balance_TextChanged(object sender, EventArgs e)
        {
            changeIndicator++;
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            double balance = Convert.ToDouble(txt_balance.Text);
            balance += 10000;
            txt_balance.Text = balance.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (changeIndicator == 0)
            {
                MessageBox.Show("Nothing has been altered/changed!");
            }
            else
            {

                String status = u.updateUser(username, Convert.ToDouble(txt_balance.Text));

                if (status == "0")
                {
                    MessageBox.Show("Change has been recorded!");
                    changeIndicator = 0;
                }
                else
                    MessageBox.Show(status);

            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {

            double balance = Convert.ToDouble(txt_balance.Text);
            balance -= 10000;
            if(balance < 0)
            {
                balance += 10000;
                MessageBox.Show("Your balance cant be negative!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                txt_balance.Text = balance.ToString();
        }

        private void btn_HomePage_Click(object sender, EventArgs e)
        {
            HomePage h = new HomePage(username);
            this.Hide();
            h.Show();
        }
    }
}
