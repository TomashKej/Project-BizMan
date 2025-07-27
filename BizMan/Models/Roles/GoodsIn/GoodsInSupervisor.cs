using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models.Roles.GoodsIn
{
    class GoodsInSupervisor : Employee
    {
        public GoodsInSupervisor()
        {
            Position = "Supervisor";
            Department = "Goods In";
        }
    }
}
