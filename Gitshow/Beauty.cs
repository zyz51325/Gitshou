using System;
using System.Collections.Generic;
using System.Text;


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