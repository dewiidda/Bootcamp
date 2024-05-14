internal class Program
{
    static void Main()
    {
        Box box1 = new(4,4);
        Box box2 = new(5,7);
        
        Box box3 = box1 + box2;
        Console.WriteLine ($"box length: {box3.Length} and box width: {box3.Width}");
    }
}
public class Box
{
	public int Length {get; set;}
	public int Width {get; set;}
	
	public Box(int length, int width)
	{
		Length = length;
		Width = width;
	}
	
	//Operator overloading
	public static Box operator +(Box b1, Box b2)
	{
		int length = b1.Length + b2.Length;
		int width = b1.Width + b2.Width;
		Box box = new(length, width);
		return box;
	}
}