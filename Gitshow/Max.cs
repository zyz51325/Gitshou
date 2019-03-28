using System;
using System.Collections.Generic;
using System.Text;

namespace Gitshow
{
    internal class Max
    {
        internal static int GetMax(int[] showarray)
        {
            int max = showarray[0];
            for (int i = 1; i < showarray.Length; i++)
            {
                if (showarray[i] >= max)
                {
                    Console.WriteLine($"第{i}次比较，比较值为{showarray[i]},目前最大值为{showarray[i]}");
                    max = showarray[i];
                }
                else
                {
                    Console.WriteLine($"第{i}次比较，比较值为{showarray[i]},目前最大值为{max}");
                }
            }
            return max;
        }
    }
}
