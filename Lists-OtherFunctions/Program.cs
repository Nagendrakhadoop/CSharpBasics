using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_OtherFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer { ID = 101, Name = "Mark", Salary = 5000 };
            Customer c2 = new Customer { ID = 110, Name = "Pam", Salary = 6500 };
            Customer c3 = new Customer { ID = 119, Name = "John", Salary = 3500 };
            List<Customer> listcust = new List<Customer>();
            listcust.Add(c1);
            listcust.Add(c2);
            listcust.Add(c3);

            //Contains function
            if (listcust.Contains(c1))
            {
                Console.WriteLine("Element is found");
            }
            else
            {
                Console.WriteLine("Element is NOT found");
            }

            //Exists function also search the item in list but is based on given condition using Lambda expression.
            if (listcust.Exists( cust => cust.Salary > 4000))
            {
                Console.WriteLine("Exists Function- Element is found");
            }
            else
            {
                Console.WriteLine("Exists Function- Element is NOT found");
            }

            //Find Fucntion
            Customer c =listcust.Find(x => x.Name.StartsWith("J"));
            Console.WriteLine("Find Function - Id= {0}, Name = {1}, Salary= {2}", c.ID, c.Name, c.Salary);

            //FindLast Function
            Customer c4 = new Customer { ID = 119, Name = "Jeff", Salary = 3500 };
            listcust.Add(c4);
            Customer findlast = listcust.FindLast(x => x.Name.StartsWith("J"));
            Console.WriteLine("FindLast Function - Id= {0}, Name = {1}, Salary= {2}", findlast.ID, findlast.Name, findlast.Salary);

            Console.WriteLine("---------------------------------------------------");

            //FindAll function
            List<Customer> findall = listcust.FindAll(x => x.Name.StartsWith("J"));
            foreach(Customer cc in findall)
            {
                Console.WriteLine("FindAll Function - Id= {0}, Name = {1}, Salary= {2}", cc.ID, cc.Name, cc.Salary);
            }
            Console.WriteLine("---------------------------------------------------");

            //FindIndex() function - it will give firstIndex position of matched item from list
            int findIndex = listcust.FindIndex(x => x.Name.StartsWith("J"));
            Console.WriteLine("findIndex Function - Id= {0}", findIndex);

            //Find Index - expects overloaded one - which search from startIndex from list
            int findIndex1 = listcust.FindIndex(3,(x => x.Name.StartsWith("J")));
            Console.WriteLine("findIndex Function - Id= {0}", findIndex1);

            //Find Index - expects overloaded one - which is startIndex and search with in number of items from list
            int findIndex2 = listcust.FindIndex(1,2,(x => x.Name.StartsWith("J")));
            Console.WriteLine("findIndex Function - Id= {0}", findIndex2);

            Console.WriteLine("---------------------------------------------------");
            //FindLastIndex function
            int findLastIndex = listcust.FindLastIndex(x => x.Salary>4000);
            Console.WriteLine("findLastIndex Function - Id= {0}", findLastIndex);

            int findLastIndex1 = listcust.FindLastIndex(3,(x => x.Salary > 4000));
            Console.WriteLine("findLastIndex Function - Id= {0}", findLastIndex1);

            int findLastIndex2 = listcust.FindLastIndex(1,2,(x => x.Salary > 6000));
            Console.WriteLine("findLastIndex Function - Id= {0}", findLastIndex2);

            Console.WriteLine("-------------Convert Array to List--------------------------------------");
            //Convert Array to List 

            Customer[] custArray = new Customer[3];
            custArray[0] = c1;
            custArray[1] = c2;
            custArray[2] = c3;

           List<Customer> l1 = custArray.ToList();
            foreach (Customer cc in l1)
            {
                Console.WriteLine("Array to List conversion - Id= {0}, Name = {1}, Salary= {2}", cc.ID, cc.Name, cc.Salary);
            }

            Console.WriteLine("-------------Convert List to Array--------------------------------------");
            List<Customer> l2 = new List<Customer>();
            l2.Add(c1);
            l2.Add(c2);
            l2.Add(c3);

            Customer[] l1Array = l2.ToArray();
            foreach (Customer cc in l1Array)
            {
                Console.WriteLine("Array to List conversion - Id= {0}, Name = {1}, Salary= {2}", cc.ID, cc.Name, cc.Salary);
            }

            Console.WriteLine("-------------Convert List to Dictionary--------------------------------------");
            List<Customer> ld2 = new List<Customer>();
            ld2.Add(c1);
            ld2.Add(c2);
            ld2.Add(c3);
            //List to Dictionary conversion : both below methods are valid.
            Dictionary<int,Customer> l1Dict = ld2.ToDictionary( x => x.ID);//we need to pass only "Key" to dictionary nad value can be taken automatically.
            Dictionary<int,Customer> l2Dict = ld2.ToDictionary( x=> x.ID, x => x);
            foreach (KeyValuePair<int,Customer> cc in l1Dict)
            {
                Console.WriteLine("Key= {0}", cc.Key);
                Console.WriteLine("List to Dictionary conversion - Id= {0}, Name = {1}, Salary= {2}", cc.Value.ID, cc.Value.Name, cc.Value.Salary);
            }
            Console.ReadKey();
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
