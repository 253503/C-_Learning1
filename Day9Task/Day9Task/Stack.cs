using System;
using System.Collections.Generic;

class Stack
{
    static void Main()
    {
        Stack<string> books = new Stack<string>();

        books.Push("Book 1");
        books.Push("Book 2");
        books.Push("Book 3");
        books.Push("Book 4");
        books.Push("Book 5");

        Console.WriteLine("Books in the Stack:");
        DisplayStack(books);

        if (books.Count > 0)
        {
            string topBook = books.Pop();
            Console.WriteLine($"\nTop Book (Popped): {topBook}");
        }
        else
        {
            Console.WriteLine("\nStack is empty.");
        }

        // Peek at the top ook in the stack without popping it
        if (books.Count > 0)
        {
            string peekedBook = books.Peek();
            Console.WriteLine($"\nTop Book (Peek): {peekedBook}");
        }
        else
        {
            Console.WriteLine("\nStack is empty.");
        }

        Console.WriteLine($"\nTotal count of books in the Stack: {books.Count}");
    }

    static void DisplayStack(Stack<string> stack)
    {
        foreach (var book in stack)
        {
            Console.WriteLine(book);
        }
    }
}