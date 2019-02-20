using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 29, 11, 34, 55, 99, 65 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)

                {
                    Console.WriteLine($"第{i}次比较:{array[i]}>{max},最大值为{array[i]}");
                    max = array[i];
                }
                else
                {
                    Console.WriteLine($"第{i}次比较:{array[i]}<={max},最大值为{max}");
                }
            }
            Console.WriteLine("因此最大值为" + max);

            Console.Read();
        }
    }
}
