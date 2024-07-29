using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{

    class Sample1
    {
        int Number1, Number2;
        public Sample1(int a, int b)
        {
            Number1 = a; Number2 = b;
        }
        public void Print()
        {
            Console.WriteLine("Number 1 :" + Number1 + " \n Number 2: " + Number2);
        }

        public static Sample1 operator +(Sample1 s1, Sample1 s2)
        {
            Sample1 s3 = new Sample1(0, 0);
            s3.Number1 = s1.Number1 + s2.Number1;
            s3.Number2 = s1.Number2 + s2.Number2;
            return s3;

        }
    }
    internal class OpeartorOverloadadd
    {
        public static void Main2()
        {
            Sample1 s1 = new Sample1(1, 2);
            Sample1 s2 = new Sample1(2, 4);
            Sample1 s3 = s1 + s2;
            s3.Print();

        }
    }

}
