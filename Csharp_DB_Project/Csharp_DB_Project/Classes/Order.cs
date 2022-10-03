using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
