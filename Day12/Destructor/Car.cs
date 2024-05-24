class Car
{
    public Car()
    {
        System.Console.WriteLine("Constructor are created");
    }

    ~Car()
    {
        System.Console.WriteLine("Destructor are called");
    }
}

// class Program
// {
//     static void Main()
//     {
//         CreateInstance();
//     }

//     public static void CreateInstance()
//     {
//         Car car = new();
//     }
// }