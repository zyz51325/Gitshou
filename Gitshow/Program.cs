using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 299, 11, 2334, 555 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            int max = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)

                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);

            Console.Read();
        }
    }
}
