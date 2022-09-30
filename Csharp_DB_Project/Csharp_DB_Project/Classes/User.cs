using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Csharp_DB_Project.Classes
{
    internal class User
    {
        public static List<User> t = new List<User>();
        public int userid { get; set; }
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
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

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
        public String viewUser(String username)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec viewUser @username";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                    SqlDataReader result = cmd.ExecuteReader();
                    while (result.Read())
                    {
                        this.userid = Convert.ToInt32(result[0]);
                        this.firstName = result[1].ToString();
                        this.lastName =  result[2].ToString();
                        this.username = result[3].ToString();   
                        this.password = result[4].ToString();
                        this.phoneNumber = result[5].ToString();
                        this.balance = Convert.ToDouble(result[6]); 
                    }
                }
                return "0";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public String updateUser(int id, String fname, String lname, String uname, String password, String phone)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec updateUser @id, @fname, @lname, @uname, @password, @phone";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value=id;
                    cmd.Parameters.Add("@fname", System.Data.SqlDbType.VarChar).Value = fname;
                    cmd.Parameters.Add("@lname", System.Data.SqlDbType.VarChar).Value = lname;
                    cmd.Parameters.Add("@uname", System.Data.SqlDbType.VarChar).Value = uname;
                    cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = password;
                    cmd.Parameters.Add("@phone", System.Data.SqlDbType.VarChar).Value = phone;
                    cmd.ExecuteNonQuery();
                }
                return "0";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public String updateUser(String username, double balance)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec updateBalance @uname, @balance";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.Add("@uname", System.Data.SqlDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@balance", System.Data.SqlDbType.Money).Value = balance;
                    cmd.ExecuteNonQuery();
                }
                return "0";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public String deleteUser(int id)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec deleteUser @id";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                    cmd.ExecuteNonQuery();
                }
                return "0";
            }
            catch (Exception e)
            {
                return e.Message;
            }



        }
        public String FetchID()
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "select dbo.FetchID(@username)";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.Add("@username", SqlDbType.VarChar).Value= this.username;
                    this.userid = Convert.ToInt32(cmd.ExecuteScalar());
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

