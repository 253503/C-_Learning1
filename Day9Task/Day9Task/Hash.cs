using System;
using System.Collections.Generic;

class Hash
{
    static void Main()
    {
        HashSet<int> numbers = new HashSet<int>();

        numbers.Add(5);
        numbers.Add(3);
        numbers.Add(7);
        numbers.Add(2);
        numbers.Add(5);
        numbers.Add(8);
        numbers.Add(3);
        numbers.Add(10);
        numbers.Add(1);
        numbers.Add(7);

        Console.WriteLine("Items in the HashSet<int>:");
        DisplayHashSet(numbers);

        int numberToRemove = 5;
        if (numbers.Contains(numberToRemove))
        {
            numbers.Remove(numberToRemove);
            Console.WriteLine($"\nRemoved {numberToRemove} from the HashSet<int>.");
        }
        else
        {
            Console.WriteLine($"\n{numberToRemove} does not exist in the HashSet<int>.");
        }

        int numberToCheck=2;
        if (numbers.Contains(numberToCheck))
        {
            Console.WriteLine($"\n{numberToCheck} exists in the HashSet<int>.");
        }
        else
        {
            Console.WriteLine($"\n{numberToCheck} does not exist in the HashSet<int>.");
        }

        Console.WriteLine($"\nTotal count of unique items in the HashSet<int>: {numbers.Count}");
    }

    static void DisplayHashSet(HashSet<int> hashSet)
    {
        foreach (var item in hashSet)
        {
            Console.WriteLine(item);
        }
    }
}