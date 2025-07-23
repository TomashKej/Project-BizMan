using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models.Roles.Inventory
{
    class InventorySupervisor : Employee
    {
        public InventorySupervisor()
        {
            Position = "Supervisor";
            Department = "Inventory";
        }
    }
}
