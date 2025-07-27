using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models.Roles
{
    class WarehouseOperative : Employee
    {
        public WarehouseOperative()
        {
            Position = "Warehouse Operative";
            Department = "Pick & Pack";
        }
    }
}
