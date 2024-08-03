using System;
using System.Collections.Generic;

class Program
{
    static void Main2()
    {
        Dictionary<string, int> students = new Dictionary<string, int>();

        students.Add("AAA", 18);
        students.Add("BBB", 16);
        students.Add("CCC", 20);
        students.Add("DDD", 14);
        students.Add("EEE", 23);

        Console.WriteLine("Key-Value pairs in the Dictionary:");
        DisplayDictionary(students);

        string studentToRemove = "DDD";
        if (students.ContainsKey(studentToRemove))
        {
            students.Remove(studentToRemove);
            Console.WriteLine($"\nRemoved {studentToRemove} from the Dictionary.");
        }
        else
        {
            Console.WriteLine($"\n{studentToRemove} does not exist in the Dictionary.");
        }

        string studentToUpdate = "AAA";
        if (students.ContainsKey(studentToUpdate))
        {
            students[studentToUpdate] = 16;
            Console.WriteLine($"\nUpdated age of {studentToUpdate} to {students[studentToUpdate]}.");
        }
        else
        {
            Console.WriteLine($"\n{studentToUpdate} does not exist in the Dictionary.");
        }

        string studentToCheck = "BBB";
        if (students.ContainsKey(studentToCheck))
        {
            Console.WriteLine($"\n{studentToCheck} exists in the Dictionary with age {students[studentToCheck]}.");
        }
        else
        {
            Console.WriteLine($"\n{studentToCheck} does not exist in the Dictionary.");
        }
        Console.WriteLine($"\nTotal count of students in the Dictionary: {students.Count}");
    }

    static void DisplayDictionary(Dictionary<string, int> dictionary)
    {
        foreach (var pair in dictionary)
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }
    }
}