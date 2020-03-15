using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
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

            Employee e = listEmployees.Find(emp => emp.ID == 102);
            Console.WriteLine("EmpId: {0}, EMpName: {1}", e.ID, e.Name);

            int count = listEmployees.Count(x => x.Name.StartsWith("M"));
            Console.WriteLine("EmpCount {0}", count);
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
