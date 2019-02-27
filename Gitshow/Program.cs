using System;
using CQ = China.Chongqing;
using TW = China.Taiwan;

namespace China.meinv
{
    class Program
    {

        static void Main(string[] args)   //方法与main并列
        {

            CQ.Beauty 蒋勤勤 = new CQ.Beauty(168, 55, "蒋勤勤", true);
            Console.WriteLine($"重庆美女{蒋勤勤.Name} 身高{蒋勤勤.Height}cm，体重{蒋勤勤.Weight}公斤，是否婚配：{蒋勤勤.Married}");//按.后自动显示参数

            TW.Beauty 林志玲 = new TW.Beauty(166, 44, "林志玲", false);
            Console.WriteLine($"台湾美女{林志玲.Name} 身高{林志玲.Height}cm，体重{林志玲.Weight}公斤，是否婚配：{林志玲.Married}");
                                       //字段.方法
            Console.Read();
        }
    }
}

namespace China.Chongqing
{
    struct Beauty //定义一个美女
    {
        public int Height;//定义身高   自己写的代码：总是给最低权限
        public int Weight;
        public string Name;
        internal bool Married;
        public static string Gender = "Female";
        public Beauty(int weight, int height, string name, bool married)//参数
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





//            //求最大值
//            int[] array = new int[] { 1, 2, 3, 8, 677, 7, 5, 4 };
//            Console.WriteLine("数组为:1,2,3,8,677,7,5,4。");
//            Shou(array);

//            Console.Read();
//        }
//        static int Shou(int[] array)
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






//随机数组

//        int length = 10;

//        int[] array = new int[length];   //方括号为长度，大括号为具体数组
//        int i = 0;
//        array[0] = 2;
//            Console.Write("您要的数组为:" + array[0] + ",");
//            Show(array,i,length );

//        array[length - 1] = array[length - 2] + new Random().Next(3, 16);
//            Console.Write(array[length - 1] + "。");
//            Console.Read();
//        }
//        static int Show(int[] array,int i,int length)
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



//数值交换


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
//            int a = 3;
//            int b = 5;
//            int t = Add(a, b);
//            Console.WriteLine("相加结果为:t="+t);
//            Console.Read();
//        }
//        static int Add(int a, int b)
//        {
//            return a + b;
//        }
//    }
//}








