using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticandInstanceClassMembers
{
    class Circle
    {
        //float _PI = 3.14F;
        //static float _PI = 3.14F;
        public static float _PI ;
        int _Radius;

        static Circle()
        {
            _PI = 3.14F;
            Console.WriteLine("In Static Constructor");
        }
        public Circle(int Radius)
        {
            this._Radius = Radius;
            Console.WriteLine("In Instance Constructor");
        }
        public float CalculateArea()
        {
            return Circle._PI * this._Radius * this._Radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PI value is {0} ", Circle._PI);

            //Circle C1 = new Circle(5);
            //float Area1 = C1.CalculateArea();
            //Console.WriteLine("Area = {0}", Area1);

            //Circle C2 = new Circle(6);
            //float Area2 = C2.CalculateArea();
            //Console.WriteLine("Area = {0}", Area2);

            Console.ReadKey();
        }
    }
}
