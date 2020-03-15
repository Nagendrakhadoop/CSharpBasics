using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
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
            //check if keys exist already or not.
            if (!dictionarycust.ContainsKey(c2.ID))
            {
                dictionarycust.Add(c2.ID, c2);
            }
            // //check if keys exist already or not.
            if (!dictionarycust.ContainsKey(135))
            {
                dictionarycust.Add(135, c2);
            }

            //faster to get value is using its key ie ID= 119.
            Customer cust119 = dictionarycust[119];
            //Console.WriteLine("Id= {0}, Name = {1}, Salary= {2}", cust119.ID, cust119.Name, cust119.Salary);

            //we can use "KayValuePair" to loop hrough dictionary which gives keys and Values separately.we can ahieve the sames using "var" keyword as well
            // foreach (KeyValuePair<int,Customer> cust  in dictionarycust)
            //foreach (var cust  in dictionarycust)
            //{
            //    //Dictionary Keys can be fetched using "Key" parameter
            //    Console.WriteLine("Key= {0}", cust.Key);

            //    //Dictionary Values can be fetched using "Value" parameter
            //    Console.WriteLine("Id= {0}, Name = {1}, Salary= {2}", cust.Value.ID, cust.Value.Name, cust.Value.Salary);
            //    Console.WriteLine("---------------------------------------------------");
            //}

            //To loop through only keys
            foreach (int keys in dictionarycust.Keys)
            {
                //Dictionary Keys can be fetched using "Key" parameter
                Console.WriteLine("Key= {0}", keys);
            }
            Console.WriteLine("---------------------------------------------------");
            //To loop through only Values
            foreach (Customer cust in dictionarycust.Values)
            {
                //Dictionary Values can be fetched using "Value" parameter
                Console.WriteLine("Id= {0}, Name = {1}, Salary= {2}", cust.ID, cust.Name, cust.Salary);
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
