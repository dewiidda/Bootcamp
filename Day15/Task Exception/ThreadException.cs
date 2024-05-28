class Program
{
    static void Main()
    {
        Thread thread = new Thread (() =>
        {
            try
            {
                Thread.Sleep(1000);
                ExceptionMaker();
                ExceptionMaker2();
            }
            catch(Exception e)
            {
                Console.WriteLine($"Exception caught: {e.Message}");
            }
        });

        thread.Start();
        System.Console.WriteLine("Finished");
    }
    
    static void ExceptionMaker()
    {
        throw new FormatException("Exception thrown from ExceptionMaker");
    }

    static void ExceptionMaker2()
    {
        throw new NullReferenceException("Exception thrown from ExceptionMaker2");
    }
}