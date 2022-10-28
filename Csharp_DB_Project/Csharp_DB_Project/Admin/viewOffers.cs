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

namespace Csharp_DB_Project.Admin
{
    public partial class viewOffers : MetroFramework.Forms.MetroForm
    {
        public viewOffers()
        {
            InitializeComponent();
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ControlBox = false;
            /*    Offer o = new Offer();
                dataGridView1.DataSource = null;
                String status = o.viewOffers(dataGridView1);
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

                dataGridView1.DataSource = context.viewOffersForAdmin();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            using (var context = new ProjectEntities())
            {

                dataGridView1.DataSource = context.searchOffersForAdmin(txt_search.Text);
            }



            /*Offer o = new Offer();
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
            }*/
        }

        private void viewOffers_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you Sure you want to delete this", "Deleting", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                using (var context = new ProjectEntities())
                {
                    context.deleteOffer((int)dataGridView1.CurrentRow.Cells[2].Value);
                    dataGridView1.DataSource = context.viewOffersForAdmin();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Hide();
                this.Show();
            }



            /*Offer o = new Offer();
            String status = o.cancelOffer((int)dataGridView1.CurrentRow.Cells[2].Value);
            if (status != "0")
                MessageBox.Show(status);
            else
                MessageBox.Show("Offer Removed");
        */
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
            txt_search.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new ProjectEntities())
            {

                dataGridView1.DataSource = context.viewOffersForAdmin();
                txt_search.Clear();
            }
        }
    }
}
