using Params.Parse;
public class Calculator
{
	// Menggunakan params untuk menerima jumlah argumen yang tidak tetap
	public int Add(params int[] numbers)
	{
		int sum = 0;
		foreach (int i in numbers)
		{
			sum += i;
		}
		return sum;
	}
}

class Program
{
	static void Main()
	{
		Calculator calc = new Calculator();

		// Anda dapat memanggil metode Add dengan jumlah argumen yang berbeda
		Console.WriteLine(calc.Add(1, 2)); // Output: 3
		Console.WriteLine(calc.Add(1, 2, 3, 4, 5)); // Output: 15

        StringCalculator calc2 = new StringCalculator();

        // Memanggil metode Add dengan array string yang masing-masing akan di-parse
        Console.WriteLine(calc2.Add("1", "2", "3")); // Output: 6
	}
}