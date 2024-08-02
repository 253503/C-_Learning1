using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace ConsoleApp14
{
    internal class Program
    {
        public static void Main()
        {
            CalculatorClient obj = new CalculatorClient();
            Console.WriteLine("Sum from another assembly");
            Console.WriteLine(obj.Sum(1, 2));
        }
    }
}