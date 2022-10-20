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
            try
            {
                using (var context = new DatabaseEntities())
                {
                    var query = from a in context.admins where a.username == txt_uname.Text && a.password == txt_passwd.Text select a;


                    if (!query.Any())
                    {
                        MessageBox.Show("invalid username or password");
                    }
                    else
                    {

                        MessageBox.Show("Success");
                        AdminPage ap = new AdminPage();
                        this.Hide();
                        ap.Show();
                    }

                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }

        }
    }
}
