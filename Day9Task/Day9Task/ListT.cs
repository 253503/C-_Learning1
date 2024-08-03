using System;
using System.Collections.Generic;

class ListT
{
    static void Main1()
    {
        List<int> numbers = new List<int>();

        numbers.Add(5);
        numbers.Add(3);
        numbers.Add(7);
        numbers.Add(2);
        numbers.Add(9);

        Console.WriteLine("Items in the List<int>:");
        DisplayList(numbers);

        numbers.RemoveAt(2);

        numbers.Insert(1, 10);

        Console.WriteLine("\nTotal count of items in the List<int>: {0}", numbers.Count);

        numbers.Sort();
        Console.WriteLine("\nSorted List<int>:");
        DisplayList(numbers);
    }

    static void DisplayList(List<int> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}