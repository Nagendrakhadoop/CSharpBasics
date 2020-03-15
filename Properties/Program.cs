using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
 {
    /* // Initial approach
    public class Student
    {
        public int ID;
        public string Name;
        public int PassMark = 35;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student C1 = new Student();
            C1.ID = -101 ;
            C1.Name = null;
            C1.PassMark = -100;

            Console.WriteLine("ID = {0} & Name = {1} & PassMark = {2}",
                C1.ID, C1.Name, C1.PassMark
                );
            Console.ReadKey();
        }
    }
    */

    /*
   // TRADITIONAL APPROACH///

   public class Student
   {
       private int _id;
       private string _name;
       private int _passMark = 35;

       public void SetId(int Id)
       {
           if(Id < 0)
           {
               throw new Exception("Student ID cannot be negative");
           }
           this._id = Id;
       }
       public int GetId()
       {
           return this._id;
       }

       public void SetName(string Name)
       {
           if (string.IsNullOrEmpty(Name))
           {
               throw new Exception("Name field cannot be empty");
           }
           this._name = Name;
       }
       public string GetName()
       {
           return string.IsNullOrEmpty(this._name) ? "No Name" : this._name ;
       }
       //To make field "PassMark" readonly implement only Getter method
       public int GetPassMark()
       {
           return this._passMark;
       }

   }
   class Program
   {
       static void Main(string[] args)
       {
           Student C1 = new Student();
           //C1.ID = -101;
           //Here "_id" field is not visible as the field is defined as private
           C1.SetId(101);
           //C1.SetName(null); //if we pass this we will get user defined exception

           Console.WriteLine("ID = {0}  & Name = {1} & PassMark = {2}", C1.GetId(), C1.GetName(), C1.GetPassMark());
           Console.ReadKey();
       }
   }
   */
    /// <summary>
    /// Prpopreties Approach using get and Set Accessor
    /// </summary>
    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;

        //private string _city;
        //private string _email;

        //public string Email
        //{
        //    set
        //    {
        //        _email = value;
        //    }
        //    get
        //    {
        //        return _email;
        //    }
        //}
        // public string City
        //{
        //    set
        //    {
        //        _city = value;
        //    }
        //    get
        //    {
        //        return _city;
        //    }
        //}

        //Auto Implemented proeprties , used when no logic exist in set/get accessors
        public string _city { set;  get; }
        public string _email { set; get; }
        public int Id
        { //here set and get accessors will called automatically.
            set {
           
           //here "value" is default property of set property.
                if (value < 0)
                {
                    throw new Exception("Student ID cannot be negative");
                }
                this._id = value;
            }

            get
            {
                return this._id;
            }
        }
        

        public string Name
        {
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name field cannot be empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
            }
        }
        
        //To make field "PassMark" readonly implement only Get Accessor
        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student C1 = new Student();
            C1.Id = 101;
            C1.Name = "ABC";
            Console.WriteLine("ID = {0}  & Name = {1} & PassMark = {2}", C1.Id, C1.Name, C1.PassMark);
            Console.ReadKey();
        }
    }


}
