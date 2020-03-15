using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegate
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
            //"employee" type is automaically inferred here.
            //Func<Employee, string> selector = employee => "Name = " + employee.Name;
            //IEnumerable<string> names = listEmployees.Select(selector);

            IEnumerable<string> names = listEmployees.Select( x => "Name=" +x.Name);
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
