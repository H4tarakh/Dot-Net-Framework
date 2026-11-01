using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Fuction_Overloading
    {
        void add(int a, int b)
        {
            Console.WriteLine("Addition of two numbers is : {0}", (a + b));
        }
        void add(int a, int b, int c)
        {
            Console.WriteLine("Addition of three numbers is : {0}", (a + b + c  ));
        }

        void add(float a, int b)
        {
            Console.WriteLine("Addition of three numbers is : {0}", (a + b));
        }
        void add(float a, float b)
        {
            Console.WriteLine("Addition of three numbers is : {0}", (a + b));
        }

        public static void Main(string[] args)
        {
            Fuction_Overloading f1 = new Fuction_Overloading();
            f1.add(10, 20);
            f1.add(10, 20, 30);
            f1.add(10.5f, 20);
            f1.add(10.5f, 20.5f);
        }
    }
}
