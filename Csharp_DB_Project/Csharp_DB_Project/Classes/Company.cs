using System;
using System.Data;
using System.Data.SqlClient;

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
                    SqlParameter name = cmd.Parameters.Add("@name", SqlDbType.VarChar);
                    name.Value = this.companyName;
                    name.Direction = ParameterDirection.Input;

                    SqlParameter type = cmd.Parameters.Add("@type", SqlDbType.VarChar);
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
        public String updateListing(int compID, String companyName, String companyType)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec updateCompany @compID, @compName, @compType";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.Add("@compID", System.Data.SqlDbType.Int).Value = compID;
                    cmd.Parameters.Add("@compName", System.Data.SqlDbType.VarChar).Value = companyName;
                    cmd.Parameters.Add("@compType", System.Data.SqlDbType.VarChar).Value = companyType;
                    cmd.ExecuteNonQuery();
                }

                return "0";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public String deleteListing(int compID)
        {
            try
            {
                sqlClass s = new sqlClass();
                System.Data.SqlClient.SqlConnection con = s.connect();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "exec deleteCompany @compID";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.Add("@compID", System.Data.SqlDbType.Int).Value = compID;
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
