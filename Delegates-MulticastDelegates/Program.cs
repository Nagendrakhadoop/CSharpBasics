using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_MulticastDelegates
{
    //public delegate void SampleDelegate();
    //public delegate int SampleDelegate();

    public delegate void SampleDelegate(out int Integer);

    class Program
    {
        static void Main(string[] args)
        {
            /*  APPROACH 1
            SampleDelegate del1, del2, del3, del4;
            //here del1,del2, del3 points to respective methods as follows.
            del1 = new SampleDelegate(SampleMethodOne);
            del2 = new SampleDelegate(SampleMethodTwo);
            del3 = new SampleDelegate(SampleMethodThree);
            //here del4 is points to del1, del2, del3 and its respective methods.
            //del4 = del1 + del2 + del3;

            //Here del2 is deregistering and its method is no longer invoked.
            del4 = del1 + del2 + del3 - del2;

            //here del4 invokes all the 3 methods/functions. Hence del4 is Multicast Delegate.
            del4();
            */

            /* APPROACH 2*/
            SampleDelegate del1 = new SampleDelegate(SampleMethodOne);
            del1 += SampleMethodTwo;

            //del1 += SampleMethodThree;
            //If we want deregister method 1 , we can use -= operator.
            //del1 -= SampleMethodOne;
            //del1();

            //for Non-Void return type methods
            //int a = del1();
            //Console.WriteLine("Return value is: {0}", a);

            //for Void with Out Params type methods
            int b = 1;
            del1(out b);
            Console.WriteLine("Return value is: {0}", b);

            Console.ReadKey();
        }
        public static void SampleMethodOne(out int Number)
        {
            Number = 1;
        }
        public static void SampleMethodTwo(out int Number)
        {
            Number = 2;
        }

        //public static int SampleMethodOne()
        //{
        //    return 1;
        //}
        //public static int SampleMethodTwo()
        //{
        //    return 2;
        //}

        //public static void SampleMethodOne()
        //{
        //    Console.WriteLine("SampleMethodOne Invoked");
        //}
        //public static void SampleMethodTwo()
        //{
        //    Console.WriteLine("SampleMethodTwo Invoked");
        //}
        //public static void SampleMethodThree()
        //{
        //    Console.WriteLine("SampleMethodThree Invoked");
        //}

    }
}
