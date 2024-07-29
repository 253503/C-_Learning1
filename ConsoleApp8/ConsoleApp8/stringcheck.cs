using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class stringcheck
    {

   
             static void Main(string[] args)
            {
                string Number = "12";
                //int ParsedNumber=int.Parse(Number);
                bool Isint = int.TryParse(Number, out int ParsedNumber);
                if (Isint)
                {
                    Console.WriteLine("You parse NUmber is : " + ParsedNumber);
                }
                else
                {
                    Console.WriteLine("its not a number");
                }


            }
        }
    }

