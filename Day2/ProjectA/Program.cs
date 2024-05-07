class Program
{
	static void Main()
	{
	
		//string food = Console.ReadLine();
		//string name = Console.ReadLine();
		Cat caty = new Cat("Whiskas","caty");
		Cat catyta = new Cat("Chicken","catyta");
		Cat catytu = new Cat("fish");
		
		caty.Eat();
		catyta.Eat();
		catytu.Eat();
		caty.PrintInfo(caty.catName);
		catyta.PrintInfo(caty.catName, caty.favoriteFood);
		//
		//caty.catName.Dump();
	}
	
}

public class Cat
{
	public string favoriteFood;
	public string catName;
	
	public Cat(string favoriteFood, string catName)//overloading
	{
		 this.favoriteFood = favoriteFood;
		 this.catName = catName;
	}
	public Cat(string favoriteFood) //overloading 1 parameter
	{
		this.favoriteFood = favoriteFood;
	}
	
	public void Eat()
	{
		Console.WriteLine(catName+" eat "+favoriteFood);
	}
	
	public void PrintInfo(string catName)
	{
		Console.WriteLine(catName);
	}

	public void PrintInfo(string catName, string favoritFood)
	{
		Console.WriteLine(catName);
		Console.WriteLine(favoriteFood);
	}

}