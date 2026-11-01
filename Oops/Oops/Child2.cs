using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Child2: Inheritance_Parent
    {
        int salary; int bonus;
        public void Accept2(int salary, int bonus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }
        public void Display2()
        {
            Console.WriteLine("Salary is : {0} and Bonus is : {1}", salary, bonus);
        }
    }
}
