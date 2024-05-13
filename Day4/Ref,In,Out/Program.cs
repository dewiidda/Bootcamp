class Program
{
    public static void Main(string[] args)
    {
        int refParameter = 7;
        int inParameter = 23;
        int outParameter;

        ExampleMethod(ref refParameter, in inParameter, out outParameter);
        Console.WriteLine(refParameter);
        Console.WriteLine(inParameter);
        Console.WriteLine(outParameter);
    }
    public static void ExampleMethod(ref int refParameter, in int inParameter, out int outParameter)
    {
	// refParameter dapat diubah
	refParameter += 10;

	// inParameter tidak dapat diubah atau read-only
	//inParameter = 10; // Ini akan menyebabkan error

	// outParameter harus diinisialisasi
	outParameter = refParameter;
    }
}
