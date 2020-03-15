using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee { ID = 101 ,Name ="Mark"},
                new Employee { ID = 102 ,Name ="John"},
                new Employee { ID = 103 ,Name ="Mary"}
            };
            ////step 2: create instance of delegate and refers to method.
            //Predicate<Employee> predicate = new Predicate<Employee>(FindEmployee);

            //step 3: invoke the method "FindEmployee" to compare the emp Id value
            //Employee e = listEmployees.Find( emp => predicate(emp));
            //by using Anonymous method

            Employee e = listEmployees.Find(

        //Here below method is anonymous method as it doesn't have any name and implements delegate instance creattion without having
        //to rewrite the separate method.
                delegate (Employee emp)
                {
                    return emp.ID == 102; 
                }
            );

            Console.WriteLine("EmpId: {0}, EMpName: {1}", e.ID,e.Name);
            Console.ReadKey();
        }
        ////step 1: Create Separate method which is to be pointed by Delegate predicate and returns boolean value.
        ////so the method should also have same signature as that of delegate declaration.
        //public static bool FindEmployee(Employee emps)
        //{
        //    return emps.ID == 102;
        //}
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
