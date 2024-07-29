using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp10
    {
        interface IDemo
        {
            public void Print();
        }

        class Example : IDemo
        {
            public void Print()
            {

                Console.WriteLine("Hi");
            }
        }
        internal class InterfaceDemo
        {
            public static void Main8()
            {
                Example e = new Example();
                e.Print();
            }
        }
    }
}
