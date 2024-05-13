//Constructor is a method run automatically when first time object created
//It is allow us to set initial values of field and limit how instance of a class created
//Without a constructor, you have to set the value of each field manually after the object is created, 
//which can be more error-prone and less efficient.
class Program
{
	static void Main()
	{
		Cat caty = new Cat();
		Cat cattyMidleton = new Cat("cheese");
	}
}

public class Cat //PascalCase for class name
{
	public string food; //camelCase for local variable
	public string name;
	
	public Cat(){} //default constructor, no parameter
	
	public Cat(string food) //constructor with 1 parameter
	{
		this.food = food;
	}
	
	public Cat(string name, string food) //constructor with 2 parameter, method overloading
	{
		this.food = food;
		this.name = name;
	}
}