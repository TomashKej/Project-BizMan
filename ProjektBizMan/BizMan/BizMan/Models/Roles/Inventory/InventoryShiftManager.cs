using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models.Roles.Inventory
{
    class InventoryShiftManager : Employee
    {
        public InventoryShiftManager()
        {
            Position = "Shift Manager";
            Department = "Inventory";
        }
    }
}
