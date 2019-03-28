using System;
using System.Collections.Generic;
using System.Text;

namespace Gitshow
{
    class mutliarray
    {
        static void Main(string[] args)
        {
            int[,] multiplearray = new int[4, 5];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 5; j++)
                {
                    multiplearray[i, j] = i + j;
                    Console.Write(multiplearray[i, j] + "   ");
                }
            }
            Console.Read();
        }
    }
}
