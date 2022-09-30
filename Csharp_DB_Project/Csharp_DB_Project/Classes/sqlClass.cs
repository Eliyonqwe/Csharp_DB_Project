using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_DB_Project.Classes
{
    internal class sqlClass
    {
       public System.Data.SqlClient.SqlConnection connect()
        {
            String conString = @"Data Source=LAPTOP-T23BOQMU;Initial Catalog=Project;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            return con;
        }
}
}
