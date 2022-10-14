using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
