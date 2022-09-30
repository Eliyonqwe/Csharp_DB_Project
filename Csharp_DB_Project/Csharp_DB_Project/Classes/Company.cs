using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_DB_Project.Classes
{
    internal class Company
    {
        public int companyID { get; set; }
        public String companyName { get; set; }
        public String companyType { get; set; }
        public String addCompany()
        {
            try
            {
                sqlClass s = new sqlClass();
               
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec addCompany @name, @type, @companyID OUTPUT";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter name  = cmd.Parameters.Add("@name", SqlDbType.VarChar);
                    name.Value = this.companyName;
                    name.Direction = ParameterDirection.Input;

                    SqlParameter type  = cmd.Parameters.Add("@type", SqlDbType.VarChar);
                    type.Value = this.companyType;
                    type.Direction = ParameterDirection.Input;

                    SqlParameter compID = cmd.Parameters.Add("@companyID", SqlDbType.Int);
                    compID.Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    this.companyID = (int)cmd.Parameters["@companyID"].Value;
                 
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
