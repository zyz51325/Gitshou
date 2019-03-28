using System;
using System.Collections.Generic;
using System.Text;

namespace Gitshow
{
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
}
