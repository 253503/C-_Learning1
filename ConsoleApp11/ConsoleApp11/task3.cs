using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Task
{
    internal class task3
    {
        class Program
        {
            static void Main6(string[] args)
            {
                Console.WriteLine(test("Python")); 
                Console.WriteLine(test("JS"));     
                Console.WriteLine(test("Code"));  
                Console.ReadLine();                
            }

            public static string test(String str)
            {
                if (str.Length > 3)
                {
                    string front = str.Substring(0, 3);
                    return front + str + front;
                }
                else
                {
                  
                    return str + str + str;

                }
            }
        }
    }
}
