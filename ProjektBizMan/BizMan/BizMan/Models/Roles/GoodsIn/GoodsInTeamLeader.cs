using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models.Roles.GoodsIn
{
    class GoodsInTeamLeader : Employee
    {
        public GoodsInTeamLeader()
        {
            Position = "Team Leader";
            Department = "Goods In";
        }
    }
}
