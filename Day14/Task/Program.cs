class Program
{
    static void Main()
    {
        
    }

    public async static void SomeMethod()
    {
        System.Console.WriteLine("Some method started..");
        await Task.Delay(TimeSpan.FromSeconds(4));
        System.Console.WriteLine("Some method end..");
    }
}