using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models.Roles.PickPack
{
    class AssistantManager : Employee
    {
        public AssistantManager()
        {
            Position = "Assistant Manager";
            Department = "Pick & Pack";
        }
    }
}
