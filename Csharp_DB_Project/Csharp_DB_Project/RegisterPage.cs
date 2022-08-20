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
    }
}
