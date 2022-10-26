using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_DB_Project.Classes
{
    internal class Order
    {
        public int orderingUserID { get; set; }
        public int selleruserID { get; set; }
        public int stockID { get; set; }
        public Double orderAmount { get; set; }

        public String addOrder(int offerID)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec addOrder @orderingID, @sellerID , @stockID ,@orderAmount , @offerID ";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.Add("@orderingID", System.Data.SqlDbType.Int).Value = this.orderingUserID;
                    cmd.Parameters.Add("@sellerID", System.Data.SqlDbType.Int).Value = this.selleruserID;
                    cmd.Parameters.Add("@stockID", System.Data.SqlDbType.Int).Value = this.stockID;
                    cmd.Parameters.Add("@orderAmount", System.Data.SqlDbType.Money).Value = this.orderAmount;
                    cmd.Parameters.Add("@offerID", System.Data.SqlDbType.Int).Value = offerID;

                    cmd.ExecuteNonQuery();
                }

                return "0";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public String searchOrder(DataGridView d, String search)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec searchOrdersForAdmin  '" + search + "'";
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
        public String searchOrder(DataGridView d, String search, int userid)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec searchMyOrder  '" + userid + "','" + search + "'";
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
        public String searchrecievedOrder(DataGridView d, String search, int userid)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec searchrecievedOrder  '" + userid + "','" + search + "'";
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
        public String viewOrders(MetroGrid d)
        {

            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec viewOrdersForAdmin";
                    SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, con);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    d.DataSource = null;
                    d.DataSource = dt;
                }

                return "0";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public String viewMyOrders(DataGridView d, int userID)
        {

            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec viewMyOrder '" + userID + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, con);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    d.DataSource = null;
                    d.DataSource = dt;
                }

                return "0";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public String viewRecievedOrders(DataGridView d, int userID)
        {

            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec viewRecievedOrder '" + userID + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, con);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    d.DataSource = null;
                    d.DataSource = dt;
                }

                return "0";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public String cancelOrder(int orderID,int sellerID, int buyerID)
        {

            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec cancelOrder @orderID, @sellerID, @buyerID";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.Add("@orderID", System.Data.SqlDbType.Int).Value = orderID;
                    cmd.Parameters.Add("@sellerID", System.Data.SqlDbType.Int).Value = sellerID;
                    cmd.Parameters.Add("@buyerID", System.Data.SqlDbType.Int).Value = buyerID;

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
