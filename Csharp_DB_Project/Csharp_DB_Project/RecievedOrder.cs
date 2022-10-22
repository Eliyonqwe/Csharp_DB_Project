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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Csharp_DB_Project
{
    public partial class RecievedOrder : Form
    {
        String username;
        int userID;
        int orderingUserID;
        int orderID;
        public RecievedOrder(String user)
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
        
        private void RecievedOrder_Load(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            
            Order o = new Order();
            String status = o.viewRecievedOrders(dataGridView1, userID);
            if (status == "0")
            {
                MessageBox.Show("success");
            }
            else
                MessageBox.Show(status);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            String status = o.cancelOrder(orderID, userID,orderingUserID);
            if (status == "0")
            {
                MessageBox.Show("success");
            }
            else
                MessageBox.Show(status);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            orderingUserID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txt_companyName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_companyType.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_amount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_orderingPrice.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            orderID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString());
        }
    }
}
