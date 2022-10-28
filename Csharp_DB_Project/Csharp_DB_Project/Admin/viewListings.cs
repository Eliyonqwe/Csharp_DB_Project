using Csharp_DB_Project.Classes;
using Csharp_DB_Project.DB;
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
    public partial class viewListings : MetroFramework.Forms.MetroForm
    {
        public viewListings()
        {
            InitializeComponent();
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ControlBox = false;

            /*stockListing s = new stockListing();
            dataGridView1.DataSource = null;
            String status = s.viewListings(dataGridView1);
            if (status == "0")
            {
                ;
            }
            else
            {
                MessageBox.Show(status);
            }*/
            using (var context = new ProjectEntities())
            {
                dataGridView1.DataSource = context.viewAllListings1();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            using (var context = new ProjectEntities())
            {

                dataGridView1.DataSource = context.searchListing(txt_search.Text);

            }





            /*stockListing s = new stockListing();
            dataGridView1.DataSource = null;
            String status = s.searchListing(dataGridView1, txt_search.Text);
            if (status == "0")
            {
                if (dataGridView1 == null)
                {
                    MessageBox.Show("no result");

                }

            }
            else
            {
                MessageBox.Show(status);
            }*/
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
            txt_search.ForeColor = Color.Black;
        }

        private void viewListings_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new ProjectEntities())
            {
                dataGridView1.DataSource = context.viewAllListings1();
                txt_search.Clear();
            }
        }
    }
}
