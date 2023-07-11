using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingRefOut
{
    internal class ForMethods
    {
        public bool CheckingOut(out int paramOut)
        {
            paramOut = 10;
            return true;
        }

        public bool CheckingRef(ref int paramRef)
        {
            paramRef = 30;
            return false;
        }
    }
}
