void Main()
{
	Circle circle = new();
	circle.Draw(); //interface
	
	Rectangle rct = new();
	rct.Draw(); //abstract class
	rct.ChangeColor("Green");
}

class Rectangle : Shape
{
	public override void Draw()
	{
		Console.WriteLine("Ini implementasikan abstract method di abstract class");
	}
}

class Circle : IShape
{
	public void Draw()
	{
		Console.WriteLine("Ini implementasikan draw dari interface");
	} 
}

class MyClass : IShape
{
	public void Draw()
	{
		
	}
}
abstract class Shape
{
	public abstract void Draw();
	public void ChangeColor(string color)
	{
		Console.WriteLine("Color change to"+color);
	}
}

interface IShape //kontrak
{
	void Draw();
	//void GetSize();
	//void CalculateArea();
}