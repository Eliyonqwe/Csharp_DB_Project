using MetroFramework.Controls;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace Csharp_DB_Project.Classes
{
    internal class User
    {
        public static List<User> t = new List<User>();
        public int userid { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime date { get; set; }
        public int age { get; set; }
        public string gender { get; set; }

        public string username { get; set; }
        public string password { get; set; }
        public string phoneNumber { get; set; }
        public double balance { get; set; }
        public String picLocation { get; set; }



        public DataTable dt;

        public String Save()
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec registerUser @fname, @lname,@gender, @uname, @pswd, @phone, @balance, @picLocation, '"+ this.date+"'";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@fname", this.firstName);
                    cmd.Parameters.AddWithValue("@lname", this.lastName);
                  //  cmd.Parameters.AddWithValue("@date",this.date.Value);
                    cmd.Parameters.AddWithValue("@gender", this.gender);
                    cmd.Parameters.AddWithValue("@uname", this.username);
                    cmd.Parameters.AddWithValue("@pswd", this.password);
                    cmd.Parameters.AddWithValue("@phone", this.phoneNumber);
                    cmd.Parameters.AddWithValue("@balance", this.balance);
                    cmd.Parameters.AddWithValue("@picLocation", this.picLocation);
                 

                    cmd.ExecuteNonQuery();
                }
                return "0";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public String viewAllUsers(DataGridView d)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec viewAllUser";
                    SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                   
                    d.DataSource = dt;
                }
                return "0";
            }

            catch (Exception e)
            {
                return e.Message;
            }

        }
        public String searchUsers(DataGridView d, String search)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "select *from searchUser('" + search + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    d.DataSource = dt;
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
                        this.lastName = result[2].ToString();
                        this.gender = result[3].ToString();
                        this.age = (int)result[9];
                        this.username = result[4].ToString();
                        this.password = result[5].ToString();
                        this.phoneNumber = result[6].ToString();
                        this.balance = Convert.ToDouble(result[7]);
                        this.picLocation = result[8].ToString();
                     
                    }
                }
                return "0";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public string checkuser(string uname, string passwd)
        {

            try
            {

                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();
                
                string sqlQuery = "select *from users where username=@username and password=@password";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.AddWithValue("@username", uname);
                cmd.Parameters.AddWithValue("@password", passwd);
                var result = cmd.ExecuteScalar();// returns 

                if (result == null) // there is no row with the entered username and password
                {
                    return "1";
                    // txt_uname.Text = "Enter Username";
                    // txt_passwd.Text = "************";
                }
                else
                {
                    return "2";
                }


            }
            catch (Exception error)
            {
                return error.Message;
            }
        }
        public String updateUser(int id, String fname, String lname, String gender, String uname, String password, String phone, int age)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();
                HomePage.username = uname;
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec updateUser @id, @fname, @lname,@gender, @uname, @password, @phone, @age";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@fname", System.Data.SqlDbType.VarChar).Value = fname;
                    cmd.Parameters.Add("@lname", System.Data.SqlDbType.VarChar).Value = lname;
                    cmd.Parameters.Add("@gender", System.Data.SqlDbType.VarChar).Value = gender;
                    cmd.Parameters.Add("@uname", System.Data.SqlDbType.VarChar).Value = uname;
                    cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = password;
                    cmd.Parameters.Add("@phone", System.Data.SqlDbType.VarChar).Value = phone;
                    cmd.Parameters.Add("@age", System.Data.SqlDbType.Int).Value = age;
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
                    cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = this.username;
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

