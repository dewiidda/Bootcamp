﻿class Program
{
    static void Main()
    {
        Task<int> task = new Task<int>(ReturnNine);
        task.Start();
        Console.WriteLine(task.Result);

        Task<string> task2 = new Task<string>(ReturnHello);
        task2.Start();
        Console.WriteLine(task2.Result);

        var task3 = new Task<Dictionary<string, int>>(ReturnDict);
        task3.Start();
        foreach(var data in task3.Result)
        {
            System.Console.WriteLine($"Penduduk: {data.Key} berumur {data.Value}");
        }
    }

    static int ReturnNine()
    {
        return 9;
    }
    static string ReturnHello()
    {
        return "Hello";
    }

    static Dictionary<string, int> ReturnDict()
    {
        Dictionary<string, int> dict = new();
        dict.Add("Yono",57);
        return dict;
    }
}