using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class taskinherit
    {

        public class Person
        {
              public int age;

            public void Greet()
            {
                Console.WriteLine("Hello!");
            }

            public void SetAge(int x)
            {
                age = x;
            }
        }

        public class Student : Person
        {
            public void Study()
            {
                Console.WriteLine("I'm studying");
            }

            public void ShowAge()
            {
                Console.WriteLine("My age is: "+age+" years old");
            }
        }

        public class Teacher : Person
        {
            public void Explain()
            {
                Console.WriteLine("I'm explaining");
            }
        }
        public class StudentProfessorTest
        {
            public static void Main7(string[] args)
            {
                Person Person = new Person();
                Person.Greet();

                Student Student = new Student();
                Student.SetAge(18);
                Student.Greet();
                Student.ShowAge();
                Student.Study();

                Teacher Teacher = new Teacher();
                Teacher.Greet();
                Teacher.Explain();
            }
        }
    }
}
