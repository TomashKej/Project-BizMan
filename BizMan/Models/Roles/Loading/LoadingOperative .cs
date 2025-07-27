using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models.Roles.Loading
{
    class LoadingOperative : Employee
    {
        public LoadingOperative()
        {
            Position = "Loading Operative";
            Department = "Loading";
        }
    }
}
