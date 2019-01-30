using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCSHarp
{
    class Program
    {

        static void Main(string[] args)
        {
            CalculatorFun(1, 9);

        }

        private static void CalculatorFun(int x, int y)
        {
            Console.WriteLine("I was asked the following question:");
            Console.WriteLine("What is " + x + " + " + y + "???");
            Console.WriteLine("I think it is like.. " + (x + y) + "... right?..");
            Console.ReadKey();
            // Þetta er betri comment
        }
    }
}
