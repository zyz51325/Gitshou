using System;
using CQ = China.Chongqing;
using TW = China.Taiwan;


namespace Gitshow
{
    class Problem
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            Console.WriteLine("要查找的数：");
            Check.Dichotomy(array);
            Console.WriteLine();
            Console.Read();
        }
        //{
        //    int[] array = new int[] { 5, 2, 8, 9, 1, 4, 7, 3, 6 };

        //    int max;

        //    for (int i = 0; i < array.Length - 1; i++)
        //    {
        //        for (int j = 0; j < array.Length - 1 - i; j++)
        //        {
        //            if (array[j] > array[j + 1])
        //            {
        //                max = array[j];
        //                array[j] = array[j + 1];
        //                array[j + 1] = max;
        //            }
        //        }
        //    }
        //    Console.Write("排列后的数组：");
        //    for (int k = 0; k < array.Length; k++)
        //    {
        //        Console.Write(1/3*3);
        //    }
        //    Console.Read();
        //}



        //{
        //    CQ.Beauty 蒋勤勤 = new CQ.Beauty(168, 55, "蒋勤勤", true);
        //    Console.WriteLine($"重庆美女{蒋勤勤.Name} 身高{蒋勤勤.Height}cm，体重{蒋勤勤.Weight}公斤，是否婚配：{蒋勤勤.Married}");//按.后自动显示参数

        //    TW.Beauty 林志玲 = new TW.Beauty(166, 44, "林志玲", false);
        //    Console.WriteLine($"台湾美女{林志玲.Name} 身高{林志玲.Height}cm，体重{林志玲.Weight}公斤，是否婚配：{林志玲.Married}");

        //    Console.Read();

        //}








        //{
        //    int length = 10;
        //    int[] array = new int[length];
        //    int i = 0;
        //    array[0] = 2;
        //    Console.Write("您要的数组为:" + array[0] + ",");
        //   RanArray.RandomArray(array, i, length);
        //    array[length - 1] = array[length - 2] + new Random().Next(1, 5);
        //    Console.Write(array[length - 1] + "。");
        //    Console.Read();
        //}

        //{
        //    bool result;
        //    Console.WriteLine("输入一个数：");
        //    int i = Convert.ToInt32(Console.ReadLine());
        //    Num_Double.Double(ref i, out result);
        //    Console.WriteLine("数值为:" + i);
        //    Console.WriteLine("事件为:" + result);
        //    Console.ReadLine();
        //}




        //{
        //    int guess = 0;
        //    GyessGame.GuessGame(guess);

        //}

        //{
        //    int a = 3;
        //    int b = 5;

        //    int t = NumberAdd.Add(a, b);
        //    Console.WriteLine("相加结果为:t=" + t);
        //    Console.Read();
        //}


        //{
        //    float a = 3.7f;
        //    float b = 5.2f;
        //    Trade.Swap(ref a, ref b);              //ref 参数传递                                  //Show（array）;
        //    Console.WriteLine("结果为:");
        //    Console.WriteLine("a=" + a);                                              //Show(int[] array);
        //    Console.WriteLine("b=" + b);
        //    Console.Read();
        //}


        //{

        //    Showarray showarray = new Showarray();
        //    Console.WriteLine("数组为:1,2,3,8,677,7,5,4。");
        //    GetMax(showarray.maxarray);
        //    Console.Read();
        //}
        //static void Main(string[] args)
        //{
        //    string[,] array2D = new string[4, 2] { { "赵", "老赵" }, { "程", "老程" },
        //                                { "龙", "小龙" }, { "金", "芦苇" }};
        //    Console.WriteLine($"{array2D[4,2]}");
        //    Console.Read();


        //}

        //{
        //    Console.WriteLine("请输入第一个数");
        //    int first = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("请输入第二个数");
        //    int second = Convert.ToInt32(Console.ReadLine());
        //    float i = (float)first / second;
        //    int j = (int)(i * 100);
        //    i = (float)j / 100;
        //    Console.WriteLine(i);
        //    Console.Read();
        //}
        //{
        //    Console.WriteLine("请输入一个数");
        //   int i = Convert.ToInt32(Console.ReadLine());

        //    if (i % 6 == 0)
        //    {
        //        Console.WriteLine("六六大顺");
        //    }
        //    else if (i % 8 == 0)
        //    {
        //        Console.WriteLine("发发发");
        //    }
        //    else
        //    {
        //        Console.WriteLine("大吉大利");
        //    }
        //    Console.Read();
        //}
        //{
        //    float i =((23 + 7) * 12 - 8) / 6F;
        //    int j = ((23 + 7) * 12 - 8) / 6;
        //    Console.WriteLine(i-j);
        //    Console.Read();
        //}






        //    //名字翻转
        //        {
        //            school("yuanzhan");
        //        }

        //空间数组
        //        {
        //            MultipleArray multiplearray = new MultipleArray();

        //        Console.WriteLine("空间数组为：");
        //            for (int i = 0; i< 4; i++)
        //            {
        //                Console.WriteLine();
        //                for (int j = 0; j< 5; j++)
        //                {
        //                    multiplearray.array[i, j] = i + j;
        //                    Console.Write(multiplearray.array[i, j] + "   ");
        //                }
        //}
        //Console.Read();

        //        }



















        //出入栈
        //{
        //    MinicStack stack = new MinicStack(10);
        //    stack.Push(8);
        //    stack.Push(33);
        //    stack.Pop();
        //    stack.Push(22);
        //    stack.Push(5);
        //    stack.Push(34);
        //    stack.Push(45);
        //    stack.Push(7);
        //    stack.Pop();
        //    stack.Pop();
        //    Console.Read();
        //}



        //Child bear = new Child();
        //Console.WriteLine("儿子有这么多钱：" + bear.OwnMoney);
        //Father father = new Father();
        //int reward = 50000;
        //bear.OwnMoney -= reward;
        //Console.WriteLine($"大儿子拿出{reward}元打赏飞哥");
        //Console.WriteLine("老子还剩下：" + father.Money);
        //Child2 bear2 = new Child2();
        //Console.WriteLine("儿子有这么多钱：" + bear2.Money);

        //int reward2 = 80000;
        //bear2.Money -= reward2;
        //Console.WriteLine($"大儿子拿出{reward2}元买家具");
        //Console.WriteLine("小儿子还剩下：" + bear2.Money);

        //GrandChild grandbear = new GrandChild();
        //Console.WriteLine("大孙子有这么多钱：" + grandbear.Money);

        //    Console.Read();

        //}





        //一年53周
        //{
        //    DateTime today = new DateTime(2019, 1, 1);
        //    Console.WriteLine("2019年1月1日为" + today.DayOfWeek.ToString() + ",");

        //    for (int i = 0; i < 7; i++)
        //    {
        //        if (today.DayOfWeek.ToString() == DayOfWeek.Sunday.ToString())
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            today = today.AddDays(1);
        //        }
        //    }
        //    Console.WriteLine($"{today.Year}年{today.Month}月{today.Day}日为该年第一个星期天。");
        //    for (int i = 0; i < (365 + 7) / 7; i++)
        //    {
        //        DateTime firstday = today.AddDays(7 * i - 7);
        //        Console.Write($"第{i + 1}周:{firstday.Year}年{firstday.Month}月{firstday.Day}日");
        //        DateTime lastday = today.AddDays(7 * i - 1);
        //        Console.WriteLine($"------{lastday.Year}年{lastday.Month}月{lastday.Day}日");

        //    }
        //    Console.Read();
        //}


















































        class MinicStack
        {
            private int[] array = null;
            private int top;
            public MinicStack(int length)
            {
                array = new int[length];
            }
            internal void Push(int value)
            {
                Console.WriteLine($"{value}入栈");
                array[top] = value;
                top++;
                Arrayshow.Inline(array);
                Console.WriteLine();
                Console.WriteLine("---------");
            }
            internal void Pop()
            {
                Console.WriteLine($"{array[top - 1]}出栈");
                array[top - 1] = 0;
                top--;
                Arrayshow.Inline(array);
                Console.WriteLine();
                Console.WriteLine("--------");
            }
        }

        internal static class Arrayshow
        {
            internal static void On(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[0]);
                }
            }

            internal static void Inline(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }

    }
}




















//值类型的值传递
//static void Main(string[] args)     
//{
//    int i = 5;
//    Show(i);
//    Console.WriteLine("i=" + i);
//    Console.Read();
//}
//static void Show(int i)
//{
//    i++;
//}


//        值类型的引用传递
//    static void Main(string[] args)
//    {
//        int i = 5;
//    Show(ref i);
//    Console.WriteLine("i=" + i);
//        Console.Read();
//    }
//static int Show(ref int i)
//{
//    i++;
//    return i;
//}
















