using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{

    class Employee
    {
        public int Employee_id;
        public int Employee_name;
        public int Employee_salary;

    }

 
    public void PrintData(Employee employee)
    {
        Console.WriteLine("Employee Details are:");
        Console.WriteLine(employee.Employee_name);
        Console.WriteLine(employee.Employee_id);
        Console.WriteLine(employee.Employee_salary);


    }



    internal class Class1
    {
        public static void Main(string[] args)
        {

            Employee employee = new Employee();
            employee.Employee_name = "Gayathri";
            employee.Employee_id = 123;
            employee.Employee_salary = 73434;
            employee.PrintData(employee);
        }
     
    }
}
