using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models.Roles.GoodsIn
{
    class GoodsInShiftManager : Employee
    {
        public GoodsInShiftManager()
        {
            Position = "Shift Manager";
            Department = "Goods In";
        }
    }
}
