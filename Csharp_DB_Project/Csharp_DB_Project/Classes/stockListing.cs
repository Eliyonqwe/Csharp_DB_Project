using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
                    string sqlQuery = "exec updateStock @stockID";
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
