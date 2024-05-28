
class Program
{
    static async Task Main()
    {
    CancellationTokenSource cts = new();
    CancellationToken token = cts.Token;

    Task task = DoWorkAsync(token);

    Console.WriteLine("Press 'C' to cancel the operation");
    if(Console.ReadKey().KeyChar == 'C')
    {
        cts.Cancel();
    }

    try
    {
        await task;
        Console.WriteLine("Operation completed");
    }
    catch(OperationCanceledException)
    {
        Console.WriteLine("Operation canceled");
    }

    static async Task DoWorkAsync(CancellationToken token)
    {
        for (int i = 0; i < 10; i++)
        {
            token.ThrowIfCancellationRequested();

            Console.WriteLine($"Work in progress: {i * 10}%");
            await Task.Delay(2000,token);
        }
    }
        }
    }