using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer { ID = 101, Name = "Mark", Salary = 5000 };
            Customer c2 = new Customer { ID = 110, Name = "Pam", Salary = 6500 };
            Customer c3 = new Customer { ID = 119, Name = "John", Salary = 3500 };
            
            ////Arrays can not grow in size automatically.It will trhow runtime error when its capacity exceeds
            //Customer[] arry = new Customer[2];
            //arry[0] = c1;
            //arry[1] = c2;
            //arry[2] = c3;
            //Console.WriteLine("Array Size");


            //Lists Can grow their capacity automatically.
            List<Customer> listcust = new List<Customer>(2);
            listcust.Add(c1);
            listcust.Add(c2);
            listcust.Add(c3);
            //listcust.Add(100); //it will throw error when try to add integer type othern class "Customer" type.


            //To insert the item at specific location, use "insert"  function.Here c3 is inserted at position "0"
            listcust.Insert(0,c3);

            foreach(Customer c in listcust)
            {
                Console.WriteLine("ID= {0}", c.ID);
            }

            //Index of function
            Console.WriteLine("Index Position= {0}", listcust.IndexOf(c3)); // it willgive 1 i.e first index position as it searching from 0th position.
            Console.WriteLine("Index Position= {0}", listcust.IndexOf(c3,1));//it will give 3 i.e as it searches from index 1.
            Console.WriteLine("Index Position= {0}", listcust.IndexOf(c3,1,2));//it will give -1 i.e as it searches from index 1 within 2 elements and couldn't find any.
            Console.WriteLine("Index Position= {0}", listcust.IndexOf(c3, 1, 3));//it will give 3 i.e as it searches from index 1 within 2 elements and couldn't find any.

            //list values can be fetched through its index as follows
            Customer cust = listcust[0];
            Console.WriteLine("Id= {0}, Name = {1}, Salary= {2}", cust.ID, cust.Name, cust.Salary);
            //Loop the list values as follows using foreach
            Console.WriteLine("--------------------FOR EACH Loop-------------------------------");
            foreach (Customer c in listcust)
            {
                Console.WriteLine("Id= {0}, Name = {1}, Salary= {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("--------------------FOR Loop-------------------------------");
            //Loop the list values as follows using for loop
            for (int i=0; i< listcust.Count; i++)
            {
                Customer c = listcust[i];
                Console.WriteLine("Id= {0}, Name = {1}, Salary= {2}", c.ID, c.Name, c.Salary);
            }
            ////inherited derived class from base class , can allow to add  the same type.
            //SavingsCustomer c4 = new SavingsCustomer();
            //listcust.Add(c4);

            Console.ReadKey();
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    //public class SavingsCustomer: Customer
    //{
       
    //}
}
