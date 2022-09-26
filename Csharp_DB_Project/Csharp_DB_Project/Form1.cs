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
    public partial class Form1 : Form
    {
        public int id;
        public Form1()
        {
            InitializeComponent();
            fill_ListBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void fill_ListBox()
        {
            try
            {
                String conString = @"Data Source=DESKTOP-49EQ2RG;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "select *from tournament";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    var result = cmd.ExecuteReader(); // returns row affected, executescalar for single element(preferebally a row)    
                    while (result.Read())
                    {
                        string tName = result.GetString(1);
                        SelectTournament.Items.Add(tName);
                        SelectTournament.Items.Add("___________________________________");
                    }
                }

            }
            catch
            {
                return;
            }

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
                        string tName = result.GetString(1);

                        id = tID;
                    }
                }
                
        
           }
            catch
            {
               return;
            }

            try
            {
                String conString = @"Data Source=DESKTOP-49EQ2RG;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    
                   // MessageBox.Show(Convert.ToString(id));
                    string sqlQuery = "select *from team where tournamentID='" + id + "'";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    var result = cmd.ExecuteReader(); // returns row affected, executescalar for single element(preferebally a row)    
                    Team team = new Team();
                    while (result.Read())
                    {
                        team.teamID = Convert.ToInt32(result[0]);
                        team.teamName = result.GetString(1);
                        Team.t.Add(team);
                        MessageBox.Show(team.teamName);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = Team.t;
                    }
                }


            }
            catch
            {
                return;
            }



        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (SelectTournament.SelectedIndex == -1)
            {
                MessageBox.Show("Error: Tournament not selected!\nPlease select a tournament First");
            }
            
            else
            {
                Team team = new Team();
                team.teamName = textBox5.Text;
                team.tournamentID = id.ToString();
                Boolean b = team.Save();

                if (b)
                    MessageBox.Show("Connected Succesfully!");
                else
                    MessageBox.Show("Unable to connect!");

                dataGridView1.DataSource = Team.t;
                // dataGridView1.Columns[0].Visible = false;
            }


        }
    }
}
