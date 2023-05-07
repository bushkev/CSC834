using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project
{
    public static class GlobalVariables
    {
        public static string ConnString { get; } = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
        public static string EventsTableName { get; } = "BgcEvents";
        public static string ClientTableName { get; } = "BgcClients";
        public static string TeamTableName { get; } = "BgcTeams";
    }
}
