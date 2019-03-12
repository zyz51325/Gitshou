using System;
//using CQ = China.Chongqing;
//using TW = China.Taiwan;


namespace home
{
    class Program
    {
        //static void Main(string[] args)






            //名字翻转
        //{
        //    school("yuanzhan");
        //}
        

        //{
        //    MultipleArray multiplearray = new MultipleArray();

        //    Console.WriteLine("空间数组为：");
        //    for (int i = 0; i < 4; i++)
        //    {
        //        Console.WriteLine();
        //        for (int j = 0; j < 5; j++)
        //        {
        //            multiplearray.array[i, j] = i + j;
        //            Console.Write(multiplearray.array[i, j] + "   ");
        //        }
        //    }
        //    Console.Read();

        //}




        //求最大值
        //{

        //    ShowArray showarray = new ShowArray();
        //    Console.WriteLine("数组为:1,2,3,8,677,7,5,4。");
        //    GetMax(showarray.maxarray);
        //    Console.Read();
        //}






        //空间数组
        //{
        //    int[,] multiplearray = new int[4, 5];
        //    for (int i = 0; i < 4; i++)
        //    {
        //        Console.WriteLine();
        //        for (int j = 0; j < 5; j++)
        //        {
        //            multiplearray[i, j] = i + j;
        //            Console.Write(multiplearray[i, j] + "   ");
        //        }
        //    }
        //    Console.Read();
        //}







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



        //猜数字
        //{
        //    int guess = 0;
        //    GuessGame(guess);
        //}






        //二分法
        //{
        //    int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

        //    Console.WriteLine("要查找的数：");
        //    Dichotomy(array);
        //    Console.WriteLine();
        //    Console.Read();
        //}



        //随机数组
        //{
        //    int length = 10;
        //    int[] array = new int[length];
        //    int i = 0;
        //    array[0] = 2;
        //    Console.Write("您要的数组为:" + array[0] + ",");
        //    RandomArray(array, i, length);
        //    array[length - 1] = array[length - 2] + new Random().Next(3, 16);
        //    Console.Write(array[length - 1] + "。");
        //    Console.Read();
        //}



        //数值翻倍
        //{
        //    bool result;
        //    Console.WriteLine("输入一个数：");
        //    int i = Convert.ToInt32(Console.ReadLine());
        //    Double(ref i, out result);
        //    Console.WriteLine("数值为:" + i);
        //    Console.WriteLine("事件为:" + result);
        //    Console.ReadLine();
        //}


        //数值相加
        //{
        //    int a = 3;
        //    int b = 5;
        //    int t = Add(a, b);
        //    Console.WriteLine("相加结果为:t=" + t);
        //    Console.Read();
        //}

        //美女比较
        //{
        //    CQ.Beauty 蒋勤勤 = new CQ.Beauty(168, 55, "蒋勤勤", true);
        //    Console.WriteLine($"重庆美女{蒋勤勤.Name} 身高{蒋勤勤.Height}cm，体重{蒋勤勤.Weight}公斤，是否婚配：{蒋勤勤.Married}");//按.后自动显示参数

        //    TW.Beauty 林志玲 = new TW.Beauty(166, 44, "林志玲", false);
        //    Console.WriteLine($"台湾美女{林志玲.Name} 身高{林志玲.Height}cm，体重{林志玲.Weight}公斤，是否婚配：{林志玲.Married}");

        //    Console.Read();

        //}



        //数值交换
        //{
        //    float a = 3.7f;
        //    float b = 5.2f;
        //    Swap(ref a, ref b);              //ref 参数传递                                  //Show（array）;
        //    Console.WriteLine("结果为:");
        //    Console.WriteLine("a=" + a);                                              //Show(int[] array);
        //    Console.WriteLine("b=" + b);
        //    Console.Read();
        //}















        static float Swap(ref float a, ref float b)
        {
            float c;
            c = a;
            a = b;
            b = c;
            return a;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Double(ref int i, out bool result)
        {
            if (i > 0)
            {
                i = i * 2;
                result = true;
            }
            else
            {
                i = 0;
                result = false;
            }
            return i;
        }
        static int RandomArray(int[] array, int i, int length)
        {
            while (i < length - 2)
            {
                i++;
                array[i] = array[i - 1] + new Random().Next(3, 16);
                Console.Write(array[i] + ",");
            }
            return array[i];
        }
        static int Dichotomy(int[] array)
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
        static int GetMax(int[] showarray)
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
        static void GuessGame(int guess)
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
        static void school(string name)
        {
            Console.WriteLine("转换前的名称为：" + name);
            char[] input = name.ToCharArray();
            char[] output = new char[name.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = input[output.Length - 1 - i];
            }
            Console.Write("转换后名称为：");
            Console.WriteLine(output);
            Console.Read();
        }


    }


    class Array
    {
        internal int[,] array = new int[4, 5];
    }

    class MultipleArray : Array
    {

    }

    class Father
    {
        protected int Money = 1000000;
    }

    class Mother
    {

    }
    class Child : Father
    {
        internal int OwnMoney;
        public Child()
        {
            OwnMoney = Money;
        }

    }
    class Child2 : Father
    {
        internal int OwnMoney = 500;

    }
    class GrandChild : Child
    {

    }


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

namespace China.Chongqing
{
    struct Beauty
    {
        public int Height;
        internal int Weight;
        public string Name;
        internal bool Married;

        public Beauty(int height, int weight, string name, bool married)
        {
            Height = height;
            Weight = weight;
            Name = name;
            Married = married;
        }
    }
}


namespace China.Taiwan
{
    struct Beauty
    {
        public int Height;
        public int Weight;
        public string Name;
        internal bool Married;
        public Beauty(int height, int weight, string name, bool married)
        {
            Height = height;
            Weight = weight;
            Name = name;
            Married = married;
        }
    }
}
















//namespace China.meinv
//{
//    class Program
//    {


//        static void Main(string[] args)
//        
//    }
//}



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
















