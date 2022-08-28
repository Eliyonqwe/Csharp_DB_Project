using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Csharp_DB_Project.Classes;

namespace Csharp_DB_Project
{
    public partial class TeamPage : Form
    {
        public TeamPage()
        {
            InitializeComponent();
        }

        private void TeamPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeamMate t = new TeamMate();
            t.name = textBox1.Text;
            t.age = Convert.ToInt32(textBox2.Text);
            if (radioButton1.Checked)
                t.gender = radioButton1.Text;
            else
                t.gender = radioButton1.Text;
            t.email = textBox4.Text;
            t.phone= textBox5.Text;
            if (radioButton3.Checked)
                t.position = radioButton3.Text;
            else if (radioButton4.Checked)
                t.position = radioButton4.Text;
            else if (radioButton5.Checked)
                t.position = radioButton5.Text;
            else
                t.position = radioButton6.Text;

            t.Save();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = TeamMate.GetAllTeamMate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*if (dataGridView1.Rows.Count < 11)
                MessageBox.Show("11 is the minimum amount of players required");
            else*/

        }
    }
}
