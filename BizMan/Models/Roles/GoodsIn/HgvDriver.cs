using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models.Roles.GoodsIn
{
    class HgvDriver : Employee
    {
        public HgvDriver()
        {
            Position = "HGV Driver";
            Department = "Goods In";
        }
    }
}
