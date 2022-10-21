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

namespace Csharp_DB_Project
{
    public partial class viewUser : Form
    {
        public viewUser()
        {
            InitializeComponent();
            User u = new User();
            dataGridView1.DataSource = null;
            String status = u.viewAllUsers(dataGridView1);
            if (status == "0")
            {
                MessageBox.Show("user data loaded!");
            }
            else
            {
                MessageBox.Show(status);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            User u = new User();
            dataGridView1.DataSource = null;
            String status = u.searchUsers(dataGridView1, txt_search.Text);
            if (status == "0")
            {
                if(dataGridView1 == null)
                {
                    MessageBox.Show("no result");

                }
               
            }
            else
            {
                MessageBox.Show(status);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPage p = new AdminPage();
            this.Hide();
            p.Show();
        }

        private void displayLsitingsControl1_Load(object sender, EventArgs e)
        {

        }

        private void viewUser_Load(object sender, EventArgs e)
        {

        }

        private void displayLsitingsControl1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
