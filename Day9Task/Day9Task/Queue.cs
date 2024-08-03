using System;
using System.Collections.Generic;

class Queue
{
    static void Main()
    {
        Queue<string> tasks = new Queue<string>();

        tasks.Enqueue("Task 1");
        tasks.Enqueue("Task 2");
        tasks.Enqueue("Task 3");
        tasks.Enqueue("Task 4");
        tasks.Enqueue("Task 5");

        Console.WriteLine("Tasks in the Queue:");
        DisplayQueue(tasks);

        if (tasks.Count > 0)
        {
            string firstTask = tasks.Dequeue();
            Console.WriteLine($"\nDequeued Task: {firstTask}");
        }
        else
        {
            Console.WriteLine("\nQueue is empty.");
        }

        if (tasks.Count > 0)
        {
            string nextTask = tasks.Peek();
            Console.WriteLine($"\nNext Task (Peek): {nextTask}");
        }
        else
        {
            Console.WriteLine("\nQueue is empty.");
        }

        Console.WriteLine($"\nTotal count of tasks in the Queue: {tasks.Count}");
    }

    static void DisplayQueue(Queue<string> queue)
    {
        foreach (var task in queue)
        {
            Console.WriteLine(task);
        }
    }
}