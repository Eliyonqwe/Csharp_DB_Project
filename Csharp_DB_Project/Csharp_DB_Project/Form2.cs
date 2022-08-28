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

namespace Csharp_DB_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tournament t = new Tournament();
            Tournament.t.Clear();
            t.Name = textBox1.Text;
            if (radioButton1.Checked)
                t.Type = radioButton1.Text;
            else if (radioButton2.Checked)
                t.Type = radioButton2.Text;
            else if (radioButton3.Checked)
                t.Type = radioButton3.Text;
            else
                t.Type = radioButton4.Text;
            t.team_no = Convert.ToInt32(textBox2.Text);
            t.location = textBox3.Text;
            if (radioButton5.Checked)
                t.gender = radioButton5.Text;
            else
                t.gender = radioButton6.Text;

            Boolean conStatus = t.Update(textBox4.Text);

            if (conStatus)
                MessageBox.Show("Connected&Updated Succesfully!");
            else
                MessageBox.Show("Unable to connect!");

        }

        private void SelectTournament_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String conString = @"Data Source=DESKTOP-49EQ2RG;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "select *from tournament where name='" + SelectTournament.Text + "'";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    var result = cmd.ExecuteReader(); // returns row affected, executescalar for single element(preferebally a row)    
                    while (result.Read())
                    {
                        int tID = Convert.ToInt32(result[0]);
                        string tName = result[1].ToString();
                        string type = result[2].ToString();
                        int x = Convert.ToInt32(result[3]);
                        string location = result[4].ToString();
                        char gender = Convert.ToChar(result[5]);

                        textBox1.Text = tName;

                        textBox2.Text = x.ToString();
                        textBox3.Text = location;

                        textBox4.Text = tID.ToString();


                    }
                }

            }
            catch
            {
                return;
            }

        }
    }
}
