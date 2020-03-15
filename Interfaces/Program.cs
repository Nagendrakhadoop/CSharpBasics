using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //interfaces starts with keyword "interface"
    interface ICustomer
    {
        ////interfaces doesn't contain fields.
        //int id;

        //interface methods are public by default.
       void Print();
    }
    //other interface I2 and it must have implemnetation in its derived class Customer
    interface I2 : ICustomer
    {
        void I2Method();
    }
    //Here class inherits interface. If class doesn't provides implementation of interface members, it give an error.
    //public class Customer : ICustomer, I2
    public class Customer : I2
    {
        public void I2Method()
        {
            Console.WriteLine("I2 Method");
        }
        public void Print()
        {
            Console.WriteLine("Interface Print Method");
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //we can not create instance to interface I2, it will give compile error
            //I2 i2 = new I2();

            //interface ref variable "cust" can points to object 
            ICustomer cust = new Customer();
            cust.Print();

            //Customer c1 = new Customer();
            //c1.Print();
            //c1.I2Method();
            Console.ReadKey();
        }
    }
}

