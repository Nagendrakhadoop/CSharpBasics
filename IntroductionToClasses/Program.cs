using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToClasses
{
    class Customer
    {
        //Following are fields
        string _firstName;
        string _lastName;
        //here "this"  keyword refers to parameter constructor Customers at line no 20
        public Customer() :this("No First Name Provided","No LastName Provided")
        {

        }
        //Constructors doesn't have return type.
        public Customer(string FirstName, string LastName)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
        }
        public void Print()
        {
            Console.WriteLine("Full Name {0} {1}",this._firstName, this._lastName);
        }

        ~Customer()
        {
            //cleanup COde
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Here COnstructor gets called when instance of its created as follows.And is used to initialize the values.
            Customer C1 = new Customer();
            C1.Print();

            Customer C2 = new Customer("Nagendra", "Prasad");
            C2.Print();
            Console.ReadKey();
        }
    }
}
