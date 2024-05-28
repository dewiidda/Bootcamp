﻿//Race condition: multi thread want to access/change the same resource

class Program
{
    static int counter = 0;
    static object key = new();
    static async Task Main()
    {
        Task task1 = IncrementCounterAsync();
        var task2 = IncrementCounterAsync();

        await Task.WhenAll(task1, task2);
        System.Console.WriteLine($"Final counter: {counter}");

    }

    static async Task IncrementCounterAsync()
    {
        lock (key)
        {
            for (int i = 0; i < 100; i++)
            {

                counter++;
                System.Console.WriteLine($"Counter from: {i}");
            }

        }
        await Task.Delay(100);
    }

}