using System;
using System.Data.SqlClient;

namespace Csharp_DB_Project.Classes
{
    internal class sqlClass
    {
        public System.Data.SqlClient.SqlConnection connect()
        {
            String conString = @"Data Source=.;Initial Catalog=Project;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            return con;
        }
    }
}
