using System;
using System.Collections.Generic;
using System.Text;

namespace Gitshow
{
    public class Trade
    {
       public static float Swap(ref float a, ref float b)
        {
            float c;
            c = a;
            a = b;
            b = c;
            return a;
        }
    }
}
