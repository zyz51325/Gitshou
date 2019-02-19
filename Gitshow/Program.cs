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
            int max = array[0] ;

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] > max)

                {
                    max = array[i];
                }
            }
            Console.WriteLine("最大值:"+max);

            Console.Read();
        }
    }
}
