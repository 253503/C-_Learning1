using System;
using System.Collections.Generic;

class SortedList
{
    static void Main()
    {
        SortedList<string, double> employees = new SortedList<string, double>();

        employees.Add("AA", 30000);
        employees.Add("BB", 40000);
        employees.Add("CC", 5000);
        employees.Add("DD", 52000);
        employees.Add("EE", 58000);

        Console.WriteLine("Employee Name \t Salary");
        Console.WriteLine("--------------------------");
        DisplaySortedList(employees);

        string employeeToRemove = "Diana";
        if (employees.ContainsKey(employeeToRemove))
        {
            employees.Remove(employeeToRemove);
            Console.WriteLine($"\nRemoved {employeeToRemove} from the SortedList.");
        }
        else
        {
            Console.WriteLine($"\n{employeeToRemove} does not exist in the SortedList.");
        }

        string employeeToUpdate = "Alice";
        if (employees.ContainsKey(employeeToUpdate))
        {
            employees[employeeToUpdate] = 52000;
            Console.WriteLine($"\nUpdated salary of {employeeToUpdate} to {employees[employeeToUpdate]}.");
        }
        else
        {
            Console.WriteLine($"\n{employeeToUpdate} does not exist in the SortedList.");
        }

        Console.WriteLine($"\nTotal count of employees in the SortedList: {employees.Count}");
    }

    static void DisplaySortedList(SortedList<string, double> sortedList)
    {
        foreach (var pair in sortedList)
        {
            Console.WriteLine($"{pair.Key,-15} \t {pair.Value,10}");
        }
    }
}