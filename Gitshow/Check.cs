using System;
using System.Collections.Generic;
using System.Text;

namespace Gitshow
{
    class Check
    {
        internal static int Dichotomy(int[] array)
        {
            int index = array.Length - 1;
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (input == array[index])
                {
                    Console.WriteLine($"找到了,共查找了{i + 1}次，位置在{index + 1}：数值为{input}");
                    break;
                }
                else
                {
                    Console.WriteLine($"第{i + 1}次查找，取第{index + 1}位值为{array[index]}");
                    if (input > array[index])
                    {
                        index = index + array.Length / (2 * (i + 1));
                    }
                    else
                    {
                        index = index - (array.Length - 1) / (2 * (i + 1));
                    }
                    Console.WriteLine($"设下一次查找位置为第{index + 1}位");

                }
            }
            return index;
        }
    }
}
