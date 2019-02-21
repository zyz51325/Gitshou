using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[] { 29, 11, 34, 55, 99, 65 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            //int max = array[0];

            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] > max)

            //    {
            //        Console.WriteLine($"第{i}次比较:{array[i]}>{max},最大值为{array[i]}");
            //        max = array[i];
            //    }
            //    else
            //    {
            //        Console.WriteLine($"第{i}次比较:{array[i]}<={max},最大值为{max}");
            //    }
            //}
            //Console.WriteLine("因此最大值为" + max);
            int random =new Random().Next(100);
            int input = 0;
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("请输入一个数:");
                string strInput = Console.ReadLine();
                input = Convert.ToInt32(strInput);

                if (input == random)
                {
                    Console.WriteLine("答对了，就是正确答案"); 
                }
                else if (input < random)
                {
                    Console.WriteLine($"第{i+1}次比较:数值小了");
                }
                else
                {
                    Console.WriteLine($"第{i+1}次比较:数值大了");
                } 
            }
            if (input != random)
            Console.WriteLine("你这个笨蛋，这都猜不对");

            Console.ReadLine();
            
       
        }
    }
}
