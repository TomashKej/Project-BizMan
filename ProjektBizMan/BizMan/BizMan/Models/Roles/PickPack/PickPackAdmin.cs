using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models.Roles.PickPack
{
    class PickPackAdmin : Employee
    {
        public PickPackAdmin()
        {
            Position = "Admin";
            Department = "Pick & Pack";
        }
    }
}
