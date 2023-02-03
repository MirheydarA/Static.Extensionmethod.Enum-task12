using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.Extensionmethod.Enum
{
    public static class Extension                      
    {
        public static bool CheckPIN(this string asd)
        {
            if (asd.Length == 7 && asd == asd.ToUpper());
            {
                return true;
            }
            return false;
        }
    }
}
