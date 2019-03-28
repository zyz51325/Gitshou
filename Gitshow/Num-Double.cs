using System;
using System.Collections.Generic;
using System.Text;

namespace Gitshow
{
    class Num_Double
    {
        internal static int Double(ref int i, out bool result)
        {
            if (i > 0)
            {
                i = i * 2;
                result = true;
            }
            else
            {
                i = 0;
                result = false;
            }
            return i;
        }
    }
}
