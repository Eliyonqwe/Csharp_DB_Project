using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//Data Source=DESKTOP-49EQ2RG;Initial Catalog=ProjectDB;Integrated Security=True
namespace Csharp_DB_Project
{
    public partial class Page : Form
    {
        public Page(String user)
        {
            InitializeComponent();
            lbl_user.Text = "Welcome back " + user;
        }

        private void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
