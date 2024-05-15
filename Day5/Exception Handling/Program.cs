/*
Best Practices:
-Only catch exceptions you can handle.
-Avoid catching System.Exception unless necessary.
-Log exceptions for debugging and troubleshooting.
*/
class Program
{
static void Main()
{   
    try
	{
		ExceptionMaker();
		
	}
    catch (FormatException e)
    {
        Console.WriteLine(e.Message);
    }
	catch (IndexOutOfRangeException e)
	{
        Console.WriteLine(e.Message);
	}
	catch (DivideByZeroException e)
	{
		//throw new Exception("Jangan pake 0");
		//e.Message.Dump();
        Console.WriteLine(e.Message);
	}
    catch (ArgumentNullException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (InvalidOperationException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (NullReferenceException e)
    {
        Console.WriteLine(e.Message);
    }
}
}

public void ExceptionMaker()
{
    //Format Exeption
	string a = "Nana27";

	//Divided by zero exception
	int x = 10, y = 0;

	//IndexOutOfRangeException
	int[] someArray = {1,2,3,4};
	Console.WriteLine(someArray[4]);
	
	//NullReferenceException
	string nama = null;
	nama.Length.Dump();
	
	//StackOverflowException
	Run()

}

static void Run()
{
	Run();
}