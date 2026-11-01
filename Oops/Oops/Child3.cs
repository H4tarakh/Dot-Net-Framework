using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Child3:Child2
    {
        int allowance;
        public void Accept3(int allowance)
        {
            this.allowance = allowance;
        }
        public void Display3()
        {
            Console.WriteLine("Allowance is : {0}", allowance);
        }
    }
}
