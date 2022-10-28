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
    public partial class viewOrders : MetroFramework.Forms.MetroForm
    {
        
        public viewOrders()
        {
            InitializeComponent();
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ControlBox = false;

            /*Order o = new Order();
            dataGridView1.DataSource = null;
            String status = o.viewOrders(dataGridView1);
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

                dataGridView1.DataSource = context.viewOrdersForAdmin();
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
                dataGridView1.DataSource = context.searchOrdersForAdmin(txt_search.Text);

            }
            /*  Order o = new Order();
             dataGridView1.DataSource = null;
             String status = o.searchOrder(dataGridView1, txt_search.Text);
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
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure you want to delete this", "Deleting", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                //do something
                using (var context = new ProjectEntities())
                {
                    context.cancelOrder((int)dataGridView1.CurrentRow.Cells[2].Value, (int)dataGridView1.CurrentRow.Cells[4].Value, (int)dataGridView1.CurrentRow.Cells[3].Value);
                    dataGridView1.DataSource = context.viewOrdersForAdmin();

                }
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Hide();
                this.Show();
            }


            /*Order o = new Order();
            String status = o.cancelOrder((int)dataGridView1.CurrentRow.Cells[6].Value, (int)dataGridView1.CurrentRow.Cells[1].Value, (int)dataGridView1.CurrentRow.Cells[0].Value);
            if (status == "0")
            {
                MessageBox.Show("success");
            }
            else
                MessageBox.Show(status);*/
        }

        private void viewOrders_Load(object sender, EventArgs e)
        {

        }

     

        private void txt_search_Click_1(object sender, EventArgs e)
        {
            txt_search.Clear();
            txt_search.ForeColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var context = new ProjectEntities())
            {
                dataGridView1.DataSource = context.viewOrdersForAdmin();
                txt_search.Clear();

            }
        }
    }
}
