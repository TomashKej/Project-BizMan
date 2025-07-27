using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models.Roles.GoodsIn
{
    class GoodsInAdmin : Employee
    {
        public GoodsInAdmin()
        {
            Position = "Admin";
            Department = "Goods In";
        }
    }
}
