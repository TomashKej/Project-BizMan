using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models.Roles.Inventory
{
    class InventoryTeamLeader : Employee
    {
        public InventoryTeamLeader()
        {
            Position = "Team Leader";
            Department = "Inventory";
        }
    }
}
