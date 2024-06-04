//Open Close Principle
//public class AreaCalculator
//{
//	public double CalculateArea(object shape)
//	{
//		if(shape is Rectangle)
//		{
//			Rectangle rect = (Rectangle)shape;
//			return rect.Height * rect.Width;
//		}
//		else if(shape is Circle)
//		{
//			Circle circle = (Circle)shape;
//			return circle.Radius * circle.Radius * Math.PI;
//		}
//		else if
//		return 0;
//	}
//}

interface IShape
{
	public double CalculateArea();
}

class Rectangle : IShape
{
	public double Width { get; set; }
	public double Height {get; set;}
	
	public double CalculateArea()
	{
		return Width * Height;
	}
}

class Circle : IShape
{
	public double Radius {get;set;}

	public double CalculateArea()
	{
		return Math.PI * Radius * Radius;
	}
}

class Triangle : IShape
{
	public double Heigth {get; set;}
	public double Width { get; set; }
	
	public double CalculateArea()
	{
		return 0.5 * Heigth * Width;
	}
}

class PrintShape
{
	public void PrintShapeResult(IShape shape)
	{
		var result = shape.CalculateArea();
		Console.WriteLine(result);
	}
}
