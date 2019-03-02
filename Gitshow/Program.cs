using System;
//using CQ = China.Chongqing;
//using TW = China.Taiwan;                      //引用类型放在堆里面，值类型有可能在堆里有可能在栈里

namespace Junior
{
    class Program
    {
   
        static void Main(string[] args)
        {
            //找最大值
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 9, 8 };
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {

                if (max > array[i])
                {
                    Console.WriteLine($"第{i}次比较，最大值为{max}");
                }
                else
                {
                    Console.WriteLine($"第{i}次比较，最大值为{array[i]}");
                    max = array[i];
                }
            }
            Console.Read();
        }



    }
    }


//            MinicStack stack = new MinicStack(10);
//            stack.Push(8);
//            stack.Push(33);
//            stack.Pop();
//            stack.Push(22);
//            stack.Push(5);
//            stack.Push(34);
//            stack.Push(45);
//            stack.Push(7);
//            stack.Pop();
//            stack.Pop();
//            Console.Read();
//        }
//    }

//    class MinicStack   //面向对象：首先定义一个类
//    {
//        private int[] array = null;   //private：实现封装,不能让人改
//        private int top;
//        public MinicStack(int length)    //构造函数
//        {
//            array = new int[length];
//        }
//        internal void Push(int value)  //压入一个数字
//        {
//            Console.WriteLine($"{value}入栈");
//            array[top] = value;         //静态static方法对应的是实例
//            top++;                   //当入栈数值等于数组数字，top自增
//            Arrayshow.Inline(array);        //inline是静态方法，直接类名点出来，实例需要new一个
//            Console.WriteLine();
//            Console.WriteLine("---------");
//        }
//        internal void Pop()
//        {
//            Console.WriteLine($"{array[top - 1]}出栈");
//            array[top - 1] = 0;
//            top--;
//            Arrayshow.Inline(array);
//            Console.WriteLine();
//            Console.WriteLine("--------");
//        }
//    }

//    internal static class Arrayshow     // 方法  ，静态方法对应实例方法
//    {
//        internal static void On(int[] array)
//        {
//            for (int i = 0; i < array.Length; i++)
//            {
//                Console.WriteLine(array[0]);
//            }
//        }
//        //internal static void On(int[][] array)
//        internal static void Inline(int[] array)
//        {
//            for (int i = 0; i < array.Length; i++)
//            {
//                Console.Write(array[i] + " ");
//            }
//        }
//    }
//}













//namespace China.meinv
//{
//    class Program
//    {


//        static void Main(string[] args)
//        {


//            DateTime today = new DateTime(2019, 1, 1);
//            Console.WriteLine("2019年1月1日为" + today.DayOfWeek.ToString() + ",");

//            for (int i = 0; i < 7; i++)
//            {
//                if (today.DayOfWeek.ToString() == DayOfWeek.Sunday.ToString())
//                {
//                    break;
//                }
//                else
//                {
//                    today = today.AddDays(1);
//                }
//            }
//            Console.WriteLine($"{today.Year}年{today.Month}月{today.Day}日为该年第一个星期天。");
//            for (int i = 0; i < (365 + 7) / 7; i++)
//            {
//                DateTime firstday = today.AddDays(7 * i - 7);
//                Console.Write($"第{i + 1}周:{firstday.Year}年{firstday.Month}月{firstday.Day}日");
//                DateTime lastday = today.AddDays(7 * i - 1);
//                Console.WriteLine($"------{lastday.Year}年{lastday.Month}月{lastday.Day}日");

//            }
//            Console.Read();
//        }
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


//        static void Main(string[] args)

//        {
//            CQ.Beauty 蒋勤勤 = new CQ.Beauty(168, 55, "蒋勤勤", true);
//            Console.WriteLine($"重庆美女{蒋勤勤.Name} 身高{蒋勤勤.Height}cm，体重{蒋勤勤.Weight}公斤，是否婚配：{蒋勤勤.Married}");//按.后自动显示参数

//            TW.Beauty 林志玲 = new TW.Beauty(166, 44, "林志玲", false);
//            Console.WriteLine($"台湾美女{林志玲.Name} 身高{林志玲.Height}cm，体重{林志玲.Weight}公斤，是否婚配：{林志玲.Married}");

//            Console.Read();

//        }
//    }
//}

//namespace China.Chongqing   //using下调用，如果重庆和台湾同时删除，则无法识别哪个地方的beauty
//{
//    struct Beauty //定义一个美女 //以上两段即为CQ.Beauty
//    {
//        public int Height;//定义身高   自己写的代码：总是给最低权限
//        internal int Weight;
//        public string Name;
//        internal bool Married;

//        //public static string Gender = "Female";
//        public Beauty(int height, int weight, string name, bool married)//参数
//        {
//            Height = height;
//            Weight = weight;
//            Name = name;
//            Married = married;
//        }

//    }
//}


//namespace China.Taiwan
//{
//    struct Beauty
//    {
//        public int Height;
//        public int Weight;
//        public string Name;
//        internal bool Married;
//        public Beauty(int height, int weight, string name, bool married)
//        {
//            Height = height;
//            Weight = weight;
//            Name = name;
//            Married = married;
//        }

//    }
//}






////求最大值
//        static void Main(string[] args)
//        {
//            int[] array = new int[] { 1, 2, 3, 8, 677, 7, 5, 4 };
//            Console.WriteLine("数组为:1,2,3,8,677,7,5,4。");
//            Show(array);
//            Console.Read();
//        }
//        static int Show(int[] array)
//        {
//            int max = array[0];
//            for (int i = 1; i < array.Length; i++)
//            {
//                if (array[i] >= max)
//                {
//                    Console.WriteLine($"第{i}次比较，比较值为{array[i]},目前最大值为{array[i]}");
//                    max = array[i];
//                }
//                else
//                {
//                    Console.WriteLine($"第{i}次比较，比较值为{array[i]},目前最大值为{max}");
//                }
//            }
//            return max;
//        }
//    }
//}







//        static void Main(string[] args)
//        {
//            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

//            Console.WriteLine("要查找的数：");
//            Show(array);
//            Console.WriteLine();
//            Console.Read();
//        }
//        static int Show(int[] array)
//        {
//            int index = array.Length - 1;
//            int input = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < array.Length - 1; i++)
//            {
//                if (input == array[index])
//                {
//                    Console.WriteLine($"找到了,共查找了{i + 1}次，位置在{index + 1}：数值为{input}");
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine($"第{i + 1}次查找，取第{index + 1}位值为{array[index]}");
//                    if (input > array[index])
//                    {
//                        index = index + array.Length / (2 * (i + 1));
//                    }
//                    else
//                    {
//                        index = index - (array.Length - 1) / (2 * (i + 1));
//                    }
//                    Console.WriteLine($"设下一次查找位置为第{index + 1}位");

//                }
//            }
//            return index;
//        }
//    }
//}






//        随机数组
//        static void Main(string[] args)
//        {
//            int length = 10;

//            int[] array = new int[length];   //方括号为长度，大括号为具体数组
//            int i = 0;
//            array[0] = 2;
//            Console.Write("您要的数组为:" + array[0] + ",");
//            Show(array, i, length);

//            array[length - 1] = array[length - 2] + new Random().Next(3, 16);
//            Console.Write(array[length - 1] + "。");
//            Console.Read();
//        }
//        static int Show(int[] array, int i, int length)
//        {


//            while (i < length - 2)
//            {
//                i++;
//                array[i] = array[i - 1] + new Random().Next(3, 16);
//                Console.Write(array[i] + ",");
//            }
//            return array[i];

//        }
//    }
//}




//        数值交换

//        static void Main(string[] args)
//        {
//            float a = 3.7f;
//            float b = 5.2f;
//            Swap(ref a, ref b);              //ref 参数传递                                  //Show（array）;
//            Console.WriteLine("结果为:");
//            Console.WriteLine("a=" + a);                                              //Show(int[] array);
//            Console.WriteLine("b=" + b);
//            Console.Read();
//        }
//        static float Swap(ref float a, ref float b)
//        {
//            float c;
//            c = a;
//            a = b;
//            b = c;
//            return a;


//        }
//    }
//}


//        static void Main(string[] args)
//        {
//            bool result;
//            Console.WriteLine("输入一个数：");
//            int i = Convert.ToInt32(Console.ReadLine());//输入一个数，转化为电脑可读的int类型
//            Double(ref i, out result);
//            Console.WriteLine("数值为:" + i);
//            Console.WriteLine("事件为:" + result);
//            Console.ReadLine();
//        }
//        static int Double(ref int i, out bool result)
//        {
//            if (i > 0)
//            {
//                i = i * 2;
//                result = true;
//            }
//            else
//            {
//                i = 0;
//                result = false;
//            }
//            return i;
//        }
//    }
//}



//数值相加
//        static void Main(string[] args)
//        {
//            int a = 3;
//            int b = 5;
//            int t = Add(a, b);
//            Console.WriteLine("相加结果为:t=" + t);
//            Console.Read();
//        }
//        static int Add(int a, int b)
//        {
//            return a + b;
//        }
//    }
//}








