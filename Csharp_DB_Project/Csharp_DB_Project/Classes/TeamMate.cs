using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Csharp_DB_Project.Classes
{
    internal class TeamMate
    {
        static List<TeamMate> t = new List<TeamMate>();
        public String name { get; set; }
        public int age { get; set; }
        public String gender { get; set; }
        public String email { get; set; }

        public String phone { get; set; }
        public String position { get; set; }
        public void Save()
        {
            t.Add(this);

        }
        public static List<TeamMate> GetAllTeamMate()
        {
            return t;
        }
    }
}
