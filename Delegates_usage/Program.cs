using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_usage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            emplist.Add(new Employee() { ID = 101, Name = "Mike", Salary = 4000, Experience = 4 });
            emplist.Add(new Employee() { ID = 101, Name = "John", Salary = 7000, Experience = 6 });
            emplist.Add(new Employee() { ID = 101, Name = "Todd", Salary = 3000, Experience = 3 });

            //IsPromotable isPromotable = new IsPromotable(Promote);

            //Employee.PromoteEmployee(emplist, isPromotable);
            
            //use lambda expression here

            Employee.PromoteEmployee(emplist, emp => emp.Experience >= 5);
            Console.ReadKey();
        }

        //public static bool Promote(Employee emp)
        //{
        //    if (emp.Experience >= 5)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}
    }
    //here return type should be  bool as the if experience promote logic in that method is bool. 
    delegate bool IsPromotable(Employee emp);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        //public static void PromoteEmployee(List<Employee> employeeList)
        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable isEligiblePromotable)
        {
            foreach(Employee emp in employeeList)
            {
                //if(emp.Experience >= 5)
                //need to replace it with delegates logic
                if(isEligiblePromotable(emp))
                {
                    Console.WriteLine("EMployee: {0} is promoted", emp.Name);
                }
            }
        }
    }
}
