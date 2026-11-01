using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Demo1
    {
        private int rno; private string name;

        // Calling via methods

        public void Accept(int rno, string name)
        {
            this.rno = rno;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("Roll No: {0} and Name is : {1}" , rno, name);
            
        }

        public static void Main(string[] args)
        {
            Demo1 d1 = new Demo1();
            d1.Accept(101, "Ravi");
            d1.Display();

            Demo1 d2 = new Demo1();
            d2.Accept(102, "Priya");
            d2.Display();
        }
    }
}
