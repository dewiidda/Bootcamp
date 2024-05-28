using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await Add(2,3);
        System.Console.WriteLine(Add.Result());
    }

    static async Task<int> Add(int a, int b)
    {
       await Task.Run(()=> {return a + b;}); 
    }
}