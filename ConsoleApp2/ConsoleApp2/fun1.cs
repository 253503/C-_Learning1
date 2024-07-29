using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class fun1
    {
        public static int Max(int a, int b, int c)
        {

            return Math.Max(a, Math.Max(b, c));

        }
        public static void Main(String[] args)
        {
            Console.WriteLine("enter number s:");
            Console.WriteLine(Max(3, 67, 5));

        }

    }
}
