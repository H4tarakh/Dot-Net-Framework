using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Oops
{
    public class Inheritance_Parent
    {
        int rno; string name;
        public void Accept(int rno, string name)
        {
            this.rno = rno;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("Roll No: {0} and Name is : {1}", rno, name);
        }
    }
}
