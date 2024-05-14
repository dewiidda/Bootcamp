class Human
{
	//Property => PascalCase => Method
	public int Balance
	{
	get {return Balance;} 
	private set //Bisa melakukan checking sebelum set value
	{
		if (value > 0 && value < 1000000)
		{
			Balance = value;
		}else
		{
			Console.WriteLine("Maaf, anda tidak boleh ngutang, uang -"); //membuat exception custom
		};
	}
	} 
	public string Name {get; set;}
	
	public void SetBalance(int balance)
	{
		Balance = balance;
	}
	
	public void PrintBalance()
	{
		Console.WriteLine(Balance);
	}
}

class Program
{
	static void Main()
	{
		Human hm = new();
		hm.SetBalance(30000000); //memberikan value ke Balance lewat method SetBalance
	}
}