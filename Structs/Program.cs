using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct Customer
    {
        //Struct can have field properties like class
        private int _id;
        private string _name;

        public int Id
        {
            get { return _id; }
            set { this._id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { this._name = value; }
        }
        // structs should have parameter constructor only
        public Customer(int ID, string Name)
        {
            this._name = Name;
            this._id = ID;
        }

        //structs can have methods
        public void Printdetails()
        {
            Console.WriteLine("Id = {0} , Name = {1}", this._id, this._name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //different ways to initialize struct or class
            Customer c1 = new Customer(12,"ABC");
            c1.Printdetails();
            
            //other aproach
            Customer c2 = new Customer();
            c2.Id = 23;
            c2.Name = "BCD";
            c2.Printdetails();

            //using Object Initializor syntax in c#3.0 which can initialize struct or class
            Customer c3 = new Customer() { Id = 34, Name = "CDE" };
            c3.Printdetails();


            Console.ReadKey();

        }
    }
}
