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
    internal class Offer
    {
        public int offeringuserID;
        public int sellerID;
        public int stockID;
        public Double offerAmount;
        public String addOffer()
        {
     
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec addOffer @offeringID, @sellerID, @stockID, @offerAmount";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.Add("@offeringID", System.Data.SqlDbType.Int).Value = this.offeringuserID;
                    cmd.Parameters.Add("@sellerID", System.Data.SqlDbType.Int).Value = this.sellerID;
                    cmd.Parameters.Add("@stockID", System.Data.SqlDbType.Int).Value = this.stockID;
                    cmd.Parameters.Add("@offerAmount", System.Data.SqlDbType.Money).Value = this.offerAmount;
                    cmd.ExecuteNonQuery();
                }

                return "0";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public String searchOffer(DataGridView d, String search)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec searchOffersForAdmin  '" + search + "'";
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
        public String viewOffers(DataGridView d)
        {

            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec viewOffersForAdmin";
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
        public String viewSentOffer(DataGridView d,int userID)
        {

            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec viewSentOffer '"+userID+"'";
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
        public String updateOffer(int offerID,int userID, double offerAmount)
        {

            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec updateOffer @offerID,@userID, @offerAmount";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.Add("@offerID", System.Data.SqlDbType.Int).Value = offerID;
                    cmd.Parameters.Add("@userID", System.Data.SqlDbType.Int).Value = userID;
                    cmd.Parameters.Add("@offerAmount", System.Data.SqlDbType.Int).Value = offerAmount;

                    cmd.ExecuteNonQuery();
                }

                return "0";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public String cancelOffer(int offerID)
        {

            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec deleteOffer @offerID";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
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
    }
}
