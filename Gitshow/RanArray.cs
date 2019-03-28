using System;
using System.Collections.Generic;
using System.Text;

namespace Gitshow
{
    class RanArray
    {
       internal static int RandomArray(int[] array, int i, int length)
    {
        while (i < length - 2)
        {
            i++;
            array[i] = array[i - 1] + new Random().Next(1, 5);
            Console.Write(array[i] + ",");
        }
        return array[i];
    }
}
}
