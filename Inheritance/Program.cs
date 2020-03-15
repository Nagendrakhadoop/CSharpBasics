using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{ 
    //base class.Usually Its Fields are private but make it as public explicitely for our use.
    //public class Employee
    //{
    //    public string FirstName;
    //    public string LastName;
    //    public string Email;
    //    public void PrintFullName()
    //    {
    //        Console.WriteLine(FirstName + " " + LastName);
    //    }
    //}
    //Derived class which uses inheritance from base class
    //and properties of base class availble in derived class i.e.
    //FullTimeEmployee class.
    //public class FullTimeEmployee: Employee
    //{
    //    public float YearlySalary;
    //}

    //public class PartTimeEmployee: Employee , A
    //{
    //    public float HourlyRate;
    //}

    //public class A :PartTimeEmployee
    //{

    //}


    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parentclass Constructor called");
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("Childclass Constructor called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass CC = new ChildClass();


            //FullTimeEmployee FTE = new FullTimeEmployee();
            //FTE.FirstName = "Nagendra";
            //FTE.LastName = "Prasad";
            //FTE.YearlySalary = 200000F;
            //FTE.PrintFullName();

            //PartTimeEmployee PTE = new PartTimeEmployee();
            //PTE.FirstName = "Nagendra";
            //PTE.LastName = "Prasad";
            //PTE.HourlyRate = 100F;
            //PTE.PrintFullName();

            Console.ReadKey();
        }
    }
}
