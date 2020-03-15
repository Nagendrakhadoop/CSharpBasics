using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsVsClasses
{
    public  class Customer //sealed
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //classes can have parameterless constructor 
        public Customer()
        {

        }
        
    }
    class Program : Customer
    {
        static void Main(string[] args)
        {
            /*
            int i = 10; //here scope of variable "i" with in Main method only.i.e. value types destoyed immediately after their scope is exits.
            if (i == 10)
            {
                // here values of i,j stored in stack as "int" is of struct type.
                int j = 20; //here scope of "j" variable is till if block i.e. value types destoyed immediately after their scope is exits.
                j = j + 1;
                
                //here reference variable "C1" stored in stack and its scope is available with in if block but its object values i.e."ID","Name" stored in Heap. 
                Customer c1 = new Customer();
                c1.ID = 23;
                c1.Name = "ABC";
            }
            */

            //FOr Value TYPES
            int i = 10; 
            int j = i;// here value of value type "i" assigned to "j" variable.and anew copy of "i" is created here.
            j = j + 1; //here though value of j incremenetd which doesn't affect the value of "i" as new copy gets created earlier
            Console.WriteLine("i = {0}, j = {1}", i, j); //the value of i is till 10 only.

            //For REFERENCE TYPES
            Customer c1 = new Customer();
            c1.ID = 34;
            c1.Name = "DEF";

            Customer c2 = c1; //assigning reference type c1 to c2.Hence its copy (ID,Name) of objects will get changed if there any changes to C2 further.
            //i.e.in Heap , only one reference object will be created.

            c2.Name = "KHJ";

            Console.WriteLine("C1.ID = {0} , C1.Name = {1} , C2.Name = {2}", c1.ID, c1.Name, c2.Name);
            Console.ReadKey();
            
        }
    }
}
