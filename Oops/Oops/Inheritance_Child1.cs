using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Inheritance_Child1: Inheritance_Parent
    {
        int salary;

        public void Accept1(int salary)
        {
            this.salary = salary;
        }

        public void Display1()
        {
            Console.WriteLine("Salary is : {0}", salary);
        }
    }
}
