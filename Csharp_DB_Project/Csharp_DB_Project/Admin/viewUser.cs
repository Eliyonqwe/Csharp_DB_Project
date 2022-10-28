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
    public partial class viewUser : MetroFramework.Forms.MetroForm
    {
        int userid;
        public viewUser()
        {
            InitializeComponent();
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ControlBox = false;


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            User u = new User();
            dataGridView1.DataSource = null;
            String status = u.searchUsers(dataGridView1, txt_search.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void viewUser_Load(object sender, EventArgs e)
        {
            using (var context = new DatabaseEntities())
            {

                var users = context.ViewAllUsers();
                dataGridView1.DataSource = users;


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            userid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_fname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_lname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_uname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_password.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_phone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();


        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure you want to delete this", "Deleting", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                using (var context = new DatabaseEntities())
                {
                    context.deleteUser(userid);
                    dataGridView1.DataSource = context.ViewAllUsers();
                    txt_id.Clear();
                    txt_fname.Clear();
                    txt_lname.Clear();
                    txt_uname.Clear();
                    txt_password.Clear();
                    txt_phone.Clear();

                }
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Hide();
                this.Show();
            }


        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseEntities())
            {
                context.updateUser(Convert.ToInt32(txt_id.Text), txt_fname.Text, txt_lname.Text, txt_uname.Text, txt_password.Text, txt_phone.Text);
                dataGridView1.DataSource = context.ViewAllUsers();
                txt_id.Clear();
                txt_fname.Clear();
                txt_lname.Clear();
                txt_uname.Clear();
                txt_password.Clear();
                txt_phone.Clear();



            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
            txt_search.ForeColor = Color.Black;
        }
    }
}
