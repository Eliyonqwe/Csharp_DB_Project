using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_DB_Project.Classes
{
    internal class Tournament
    {
        static List<Tournament> t = new List<Tournament>();
        public String Name { get; set; }
        public String Type { get; set; }
        public int team_no { get; set; }
        public String location { get; set; }
        public String gender { get; set; }

        public void Save()
        {
            t.Add(this);

        }
        public static List<Tournament> GetAllTournament()
        {
            return t;
        }
    }

}
