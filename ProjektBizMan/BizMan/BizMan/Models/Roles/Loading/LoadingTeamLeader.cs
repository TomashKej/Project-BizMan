using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models.Roles.Loading
{
    class LoadingTeamLeader : Employee
    {
        public LoadingTeamLeader()
        {
            Position = "Team Leader";
            Department = "Loading";
        }
    }
}
