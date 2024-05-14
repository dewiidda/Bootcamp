class Program
{
    static void Main()
{
	int? a = null;
	
	Nullable<int> nullableInt = null;
	int? nullableIntt = null;
	
	if (a.HasValue)
	{
		Console.WriteLine($"a is:{a}");
	}
	else
	{
		Console.WriteLine("a doesn't have a value");
	}

}
}