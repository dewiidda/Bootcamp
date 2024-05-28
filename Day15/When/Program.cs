using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // Task task1 = Task.Run(()=> Console.WriteLine("1"+"1"));
        // Task task2 = Task.Run(()=> Console.WriteLine("Hello "));

        // //Task.WhenAll(task1, task2);
        // Task.WaitAll(task1, task2); //blocking main thread
        // Console.WriteLine("Finished");

        Task task1 = Task.Run(async ()=> {await Task.Delay(2000); Console.WriteLine("Task 1");});
        Task task2 = Task.Run(async ()=> {await Task.Delay(2000); Console.WriteLine("Task 2");});
        
        Task completedTask = await Task.WhenAny(task1, task2);
        Console.WriteLine($"First completed task: "+(completedTask == task1 ? "Task 1": "Task 2"));
    }
}