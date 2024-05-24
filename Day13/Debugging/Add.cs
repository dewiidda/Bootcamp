using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int result = Add(5, 3);
        Console.WriteLine($"Result: {result}");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}
