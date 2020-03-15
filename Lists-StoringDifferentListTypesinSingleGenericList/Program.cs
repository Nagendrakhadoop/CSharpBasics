using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_StoringDifferentListTypesinSingleGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> lobj = new List<object>();
            lobj.Add(1000);
            lobj.Add(2000);
            lobj.Add("Nagendra");//Add different object datatypes like string, int to list of Object.

            List<object> l1obj = new List<object>();
            l1obj.Add(3.4f);
            l1obj.Add(2.3f);//Add different object datatypes like Float, string to list of Object.
            l1obj.Add("Prasad");

            //Create Generic List with list of objects
            List<List<object>> listofListObjects = new List<List<object>>();
            listofListObjects.Add(lobj);
            listofListObjects.Add(l1obj); //add both lobj & l1obj

            //loop through 
            foreach (List<object> l1 in listofListObjects)
            {
                foreach(object o in l1)
                {
                    Console.WriteLine("Single object: {0} ", o);
                }
                Console.WriteLine("List of object:  {0}", l1);
            }
            Console.ReadKey();

        }
        
    }
}
