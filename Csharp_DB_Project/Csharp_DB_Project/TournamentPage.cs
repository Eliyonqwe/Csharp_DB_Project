﻿using System;
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
    public partial class TournamentPage : Form
    {
        public TournamentPage()
        {
            InitializeComponent();
        }

        private void TournamentPage_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tournament t = new Tournament();
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

            t.Save();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Tournament.GetAllTournament();
            

        }
    }
}
