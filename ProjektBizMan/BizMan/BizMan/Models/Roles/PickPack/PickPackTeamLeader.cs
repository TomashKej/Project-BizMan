using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models.Roles
{
    class PickPackTeamLeader : Employee
    {
        public PickPackTeamLeader()
        {
            Position = "Team Leader";
            Department = "Pick & Pack";
        }
    }
}
