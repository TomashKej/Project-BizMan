using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models.Roles.Inventory
{
    class InventoryOperative : Employee
    {
        public InventoryOperative()
        {
            Position = "Inventory Operative";
            Department = "Inventory";
        }
    }
}
