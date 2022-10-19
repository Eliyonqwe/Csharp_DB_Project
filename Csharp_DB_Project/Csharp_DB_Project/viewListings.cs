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
    public partial class viewListings : Form
    {
        public viewListings()
        {
            InitializeComponent();
            stockListing s = new stockListing();
            dataGridView1.DataSource = null;
            String status = s.viewListings(dataGridView1);
            if (status == "0")
            {
                MessageBox.Show("user data loaded!");
            }
            else
            {
                MessageBox.Show(status);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            stockListing s = new stockListing();
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
            }
        }
    }
}
