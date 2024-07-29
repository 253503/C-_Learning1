using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;





namespace ConsoleApp10
{
   public class People
    {
        public static void Main3(string[] args)
        {
            int total = 3;
            Person[] persons = new Person[total];

            for (int i = 0; i < total; i++)
            {
                persons[i] = new Person(Console.ReadLine());

            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }
          public class Person

        {
            public string Name { get; set; }

            public Person(string name)
            {
                Name = name;
            }
            public override string ToString()
            {
                return ("Hello! My name is " + Name);

            }
            ~Person()
            {
                Name = string.Empty;
            }

        }
      
    }
}