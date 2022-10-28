using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Net.PeerToPeer;
using System.Security.Cryptography;

namespace Csharp_DB_Project.Classes
{
    internal class stockListing
    {
        public static List<stockListing> s = new List<stockListing>();
        public int stockID { get; set; }
        public int companyID { get; set; }
        public int userID { get; set; }
        public double amount { get; set; }
        public double price { get; set; }
        String status { get; set; }
        public String viewListings(DataGridView d)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec viewAllListings";
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

        public String searchListing(DataGridView d, String search)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "select *from searchListing('" + search + "')";
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

        public String viewListingData(DataGridView d, String username)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "select stockID, companyName, companyType, amount, price, status from viewListing where username = '" + username + "' and status = 'pending'";
                    SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, con);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    d.DataSource = dt;
                }
                return "0";

            }


            catch (Exception ex)
            {
                return ex.Message;
            }
    }


        public String addListing()
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec addListing @compID, @userID, @amount, @price";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.Add("@compID", System.Data.SqlDbType.Int).Value = this.companyID;
                    cmd.Parameters.Add("@userID", System.Data.SqlDbType.Int).Value = this.userID;
                    cmd.Parameters.Add("@amount", System.Data.SqlDbType.Money).Value = this.amount;
                    cmd.Parameters.Add("@price", System.Data.SqlDbType.Money).Value = this.price;
                    cmd.ExecuteNonQuery();
                }

                return "0";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public String updateListing(int stockID, double amount, double price)
        {
           
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec updateStock @stockID, @amount, @price";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.Add("@stockID", System.Data.SqlDbType.Int).Value = stockID;
                    cmd.Parameters.Add("@amount", System.Data.SqlDbType.Money).Value = amount;
                    cmd.Parameters.Add("@price", System.Data.SqlDbType.Money).Value = price;
                    cmd.ExecuteNonQuery();
                }

                return "0";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public String deleteListing(int stockID)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec deleteStock @stockID";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.Add("@stockID", System.Data.SqlDbType.Int).Value = stockID;
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
