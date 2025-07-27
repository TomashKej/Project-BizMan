using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models.Roles.Loading
{
    class LoadingShiftManager : Employee
    {
        public LoadingShiftManager()
        {
            Position = "Loading Shift Manager";
            Department = "Loading";
        }
    }
}
