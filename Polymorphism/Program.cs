using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee
    {
        public string FirstName;
        public string LastName;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTimeEmployee : Employee
    {

    }
    public class FullTimeEmployee : Employee {

    }

    public class TemporaryEmployee : Employee
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];

        }
    }
}
