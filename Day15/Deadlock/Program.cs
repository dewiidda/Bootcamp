﻿using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        System.Console.WriteLine("Main thread started");
        Task task1 = null;
        Task task2 = null;

        task1 = Task.Run(async()=>
        {
            System.Console.WriteLine("Task 1 started");
            await Task.Delay(1000);

            System.Console.WriteLine("Task 1 waiting for Task 2");
            await task2;
        });

        task2 = Task.Run(async()=>
        {
            System.Console.WriteLine("Task 2 started");
            await Task.Delay(1000);

            System.Console.WriteLine("Task 2 waiting for Task 1");
            await task1;
        });

        await Task.WhenAll(task1, task2);
        System.Console.WriteLine("All tasks completed");
    }
}