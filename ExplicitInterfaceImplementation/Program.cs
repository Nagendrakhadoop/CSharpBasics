using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceImplementation
{
    interface I1
    {
        void InterfaceMethod();
    }
    //Let say other Interface I2 has similar method
    interface I2
    {
        void InterfaceMethod();
    }
    public class Program :I1, I2
    {
        public void InterfaceMethod()
        {
            Console.WriteLine("I1 Interface method");
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.InterfaceMethod();
            Console.ReadKey();
        }
    }
}
