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

namespace Csharp_DB_Project.Admin
{
    public partial class viewOffers : Form
    {
        public viewOffers()
        {
            InitializeComponent();
            Offer o = new Offer();
            dataGridView1.DataSource = null;
            String status = o.viewOffers(dataGridView1);
            if (status == "0")
            {
                MessageBox.Show("offer data loaded!");
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            Offer o = new Offer();
            dataGridView1.DataSource = null;
            String status = o.searchOffer(dataGridView1, txt_search.Text);
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

        private void viewOffers_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Offer o = new Offer();
            String status = o.cancelOffer((int)dataGridView1.CurrentRow.Cells[2].Value);
            if (status != "0")
                MessageBox.Show(status);
            else
                MessageBox.Show("Offer Removed");
        }
    }
}
