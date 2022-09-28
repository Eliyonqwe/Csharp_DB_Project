using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_DB_Project.Classes
{
    internal class User
    {
        public static List<User> t = new List<User>();
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string phoneNumber { get; set; }
        public double balance { get; set; }

        public String Save()
        {
            try
            {
                String conString = @"Data Source=DESKTOP-49EQ2RG;Initial Catalog=Project;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec registerUser @fname, @lname, @uname, @pswd, @phone, @balance";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@fname", this.firstName);
                    cmd.Parameters.AddWithValue("@lname", this.lastName);
                    cmd.Parameters.AddWithValue("@uname", this.username);
                    cmd.Parameters.AddWithValue("@pswd", this.password);
                    cmd.Parameters.AddWithValue("@phone", this.phoneNumber);
                    cmd.Parameters.AddWithValue("@balance", this.balance);
                    cmd.ExecuteNonQuery();
                }
                return "0";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        


    }


    }

