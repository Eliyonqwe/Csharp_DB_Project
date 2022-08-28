using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_DB_Project.Classes
{
    internal class Team
    {
        public static List<Team> t = new List<Team>();
        public String teamName;
        public String tournamentID;

        public Boolean Save()
        {
            t.Add(this);
            try
            {
                String conString = @"Data Source=DESKTOP-49EQ2RG;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "insert into team values(@name, @tId)";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@name", this.teamName);
                    cmd.Parameters.AddWithValue("@tID", this.tournamentID);
                    cmd.ExecuteNonQuery();
                    
                }
               return true;
            }
            catch (Exception)
            {
               return false;
            }


        }
    }
}
