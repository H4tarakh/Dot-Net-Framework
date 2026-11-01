namespace Oops
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //    Single Inheritance
            Inheritance_Child1 c1 = new Inheritance_Child1();
            c1.Accept(101, "Ravi");
            c1.Display();
            c1.Accept1(50000);
            c1.Display1();

            //    Hierarchical Inheritance
            Child2 c2= new Child2();
            c2.Accept2(50000, 10000);
            c2.Display2();

            //    Multilevel Inheritance
            Child3 c3= new Child3();
            c3.Accept3(5000);
            c3.Display3();

        }
    }
}
