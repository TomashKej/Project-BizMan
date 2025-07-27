using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models.Roles.Loading
{
    class LoadingController : Employee
    {
        public LoadingController()
        {
            Position = "Loading Controller";
            Department = "Loading";
        }
    }
}
