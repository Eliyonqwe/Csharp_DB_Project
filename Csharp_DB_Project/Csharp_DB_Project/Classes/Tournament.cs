using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Csharp_DB_Project.Classes
{
    internal class Tournament
    {
        public static List<Tournament> t = new List<Tournament>();
        public String Name { get; set; }
        public String Type { get; set; }
        public int team_no { get; set; }
        public String location { get; set; }
        public String gender { get; set; }

        public Boolean Save()
        {
            try
            {
                String conString = @"Data Source=DESKTOP-49EQ2RG;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "insert into tournament(name) values(@name)";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@name", this.Name);
                    cmd.ExecuteNonQuery();     
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean Update(string id)
        {
            try
            {
                String conString = @"Data Source=DESKTOP-49EQ2RG;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "update tournament set name= @newname where tournamentid=" + id;
                    SqlCommand cmd = new SqlCommand(sqlQuery, con); 
                    cmd.Parameters.AddWithValue("@newname", this.Name);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static List<Tournament> GetAllTournament()
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
                        Tournament tx = new Tournament();
                        tx.Name = result[1].ToString();
                        Tournament.t.Add(tx);
                    }
                }
                return Tournament.t;
            }
            catch
            {
                return null;
            }
         }
    }

}
