using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models.Roles.PickPack
{
    class PickPackSupervisor : Employee
    {
        public PickPackSupervisor()
        {
            Position = "Supervisor";
            Department = "Pick & Pack";
        }
    }
}
