using System;
using System.Collections.Generic;
using System.Text;

namespace Gitshow
{
    class GyessGame
    {
        internal static void GuessGame(int guess)
        {
            int max = 100;
            int random = new Random().Next(max);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("输入一个数：");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == random)
                {
                    Console.WriteLine("恭喜答对了！");
                    break;
                }
                else if (input > random)
                {
                    Console.WriteLine($"太大了，只剩{9 - i}次了！");
                }
                else
                    Console.WriteLine($"太小了，只剩{9 - i}次了哦！");
            }
            if (guess != random)
            {
                Console.WriteLine($"错了，正确答案是{random}");
            }
            Console.ReadLine();
        }
    }
}
