using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project
{
    public class TeamMember
    {
        public int clientID { get;}
        public string FullName { get;}

        public TeamMember(int id, string name) 
        { 
            clientID = id;
            FullName = name;
        }

    }
}
