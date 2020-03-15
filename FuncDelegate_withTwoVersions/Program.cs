using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegate_withTwoVersions
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, string> funcdeleagte = (firstNumber, SecondNumber) => "Value = " + (firstNumber + SecondNumber).ToString();
            string result = funcdeleagte(10, 20);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
