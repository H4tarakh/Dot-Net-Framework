using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Demo2
    {
        public int rno; public string name;

        // Default Constructor and Parameterized Constructor

        Demo2(){
            rno=21;
            name= "Onkar";
        }

        Demo2(int rno, string name)
        {
            this.rno = rno;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("Roll No: {0} and Name is : {1}", rno, name);

        }

        public static void Main(string[] args)
        {
            Demo2 d1 = new Demo2();
            d1.Display();

            Demo2 d2 = new Demo2(90,"Amaan");
            d2.Display();
        }
    }
}
