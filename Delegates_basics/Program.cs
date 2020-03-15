using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_basics
{
    //here Delegate's signature is same as that of function "hello".i.e.it's expect input parameter with type "string".

    public delegate void HelloFunctionDelegate(string strMessages);
    class Program
    {
        static void Main(string[] args)
        {
 
//here Delegates constructors gets called or Delegates instantiation done and its expect reference(pointing) to function "hello".

            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
 //Invoking Delegates expect input same as function and it calls the function "Hello".
            del("Hello from Delegate");

            Console.ReadKey();
        }

        //function declaration
        public static void Hello(string messages)
        {
            Console.WriteLine(messages);
        }
    }
}
