using Csharp_DB_Project.Classes;
using Csharp_DB_Project.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure.Interception;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_DB_Project
{
    public partial class AdminLoginPage : Form
    {
        public AdminLoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            string status = a.check(txt_uname.Text, txt_passwd.Text);
            if (status == "0")
            {
                MessageBox.Show("Success");
                AdminPage ap = new AdminPage();
                this.Hide();
                ap.Show();
            }
            else
            {
                MessageBox.Show(status);
            }

        }
    }
}
