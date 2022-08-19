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
            
        }
    }
}
