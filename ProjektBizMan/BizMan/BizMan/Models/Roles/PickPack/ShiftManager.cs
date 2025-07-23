using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models.Roles.PickPack
{
    class ShiftManager : Employee
    {
        public ShiftManager()
        {
            Position = "Shift Manager";
            Department = "Pick & Pack";
        }
    }
}
