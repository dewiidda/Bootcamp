using System.Threading.Tasks;

class Program
{
    static SemaphoreSlim semaphore = new(2);

    static async Task Main()
    {
        Task[] tasks = new Task[10];
        for (int i = 0; i < tasks.Length; i++)
        {
            int index = i;
            tasks[i] = Task.Run(async () => await DoWork(index));
        }
        await Task.WhenAll();
    }

    static async Task DoWork(int index)
    {
        Console.WriteLine($"Task {index} started");

        await semaphore.WaitAsync();
        await Task.Delay(500);
        Console.WriteLine($"Task {index} processing");
        await Task.Delay(500);
        semaphore.Release();

        Console.WriteLine($"Task {index} finished");
    }
}