using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_AdditionalMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer { ID = 101, Name = "Mark", Salary = 5000 };
            Customer c2 = new Customer { ID = 110, Name = "Pam", Salary = 6500 };
            Customer c3 = new Customer { ID = 119, Name = "John", Salary = 3500 };

            Dictionary<int, Customer> dictionarycust = new Dictionary<int, Customer>();
            dictionarycust.Add(c1.ID, c1);
            dictionarycust.Add(c2.ID, c2);
            dictionarycust.Add(c3.ID, c3);
            
            //TryGetValue property
            Customer cust;
            if(dictionarycust.TryGetValue(101, out cust))//if we pass 120, we will not get any though key is not exists in dictionary
            {
                Console.WriteLine("Id= {0}, Name = {1}, Salary= {2}", cust.ID, cust.Name, cust.Salary);
            }
            else
            {
                Console.WriteLine("Key is not found");
            }

            //Count property
            Console.WriteLine("Count={0}",dictionarycust.Count);
            //count() function.Here count() function is a LINQ query.
            Console.WriteLine("Count={0}", dictionarycust.Count());
            //to find count of total no.of customers whose salary >4000)
            Console.WriteLine("Salary >4000 is {0}", dictionarycust.Count(kvp => kvp.Value.Salary > 4000));

            //Remove Property
            dictionarycust.Remove(101);
            Console.WriteLine("Count={0}", dictionarycust.Count);

            Console.WriteLine("----------------Convert Array To dictionary--------------------------");
            //Convert Array to Dictionary
            Customer[] customersArray = new Customer[3];
            customersArray[0] = c1;
            customersArray[1] = c2;
            customersArray[2] = c3;

          Dictionary<int,Customer> custDict  = customersArray.ToDictionary(custs => custs.ID, custs => custs);

            foreach(KeyValuePair<int,Customer> kvp in custDict)
            {
                Console.WriteLine("Key={0}", kvp.Key);
                Console.WriteLine("Id= {0}, Name = {1}, Salary= {2}", kvp.Value.ID, kvp.Value.Name, kvp.Value.Salary);
                Console.WriteLine("---------------------------------------------------");
            }
            //Convert List To dictionary
            Console.WriteLine("----------------Convert List To dictionary--------------------------");
            List<Customer> listCust = new List<Customer>();
            listCust.Add(c1);
            listCust.Add(c2);
            listCust.Add(c3);

             Dictionary<int,Customer> listDict = listCust.ToDictionary(lists => lists.ID, lists => lists);
            foreach(KeyValuePair<int,Customer> kvp in listDict)
            {
                Console.WriteLine("Key={0}", kvp.Key);
                Console.WriteLine("Id= {0}, Name = {1}, Salary= {2}", kvp.Value.ID, kvp.Value.Name, kvp.Value.Salary);
                Console.WriteLine("---------------------------------------------------");
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
