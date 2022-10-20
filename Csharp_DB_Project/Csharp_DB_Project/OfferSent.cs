using Csharp_DB_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Csharp_DB_Project
{
    public partial class OfferSent : Form
    {
        String username;
        int userID;
        public OfferSent(String user)
        {
            InitializeComponent();
            username = user;

            User u = new User();
            u.username = user;

            String status = u.FetchID(); //fetches current user's id. It is NOT the seller's id
            if (status == "0")
            {
                userID = u.userid;
            }
            else
                MessageBox.Show(status);

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            Offer o = new Offer();
            String status = o.viewSentOffer(dataGridView1,userID);
            if (status != "0")  
                MessageBox.Show(status);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage h = new HomePage(username);
            this.Hide();
            h.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_companyName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_companyType.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_amount.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_price.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_offeramount.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Offer o = new Offer();
            String status = o.updateOffer((int)dataGridView1.CurrentRow.Cells[0].Value, userID,Convert.ToDouble(txt_offeramount.Text));
            if (status != "0")
                MessageBox.Show(status);
            else
                MessageBox.Show("updated");
        }
    }
}
