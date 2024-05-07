namespace Vehicle;

public class Wheel
{
    public string wheelType;
    public int wheelDiameter;
    public string wheelBrand;

    public Wheel(
        string wheelType, 
        int wheelDiameter, 
        string wheelBrand)
    {
        this.wheelType = wheelType;
        this.wheelDiameter = wheelDiameter;
        this.wheelBrand = wheelBrand;
    }

    public void PrintAtrribute()
    {
        Console.WriteLine($"This wheel type is {wheelType}");
        Console.WriteLine($"This wheel diameter is {wheelDiameter}");
        Console.WriteLine($"This wheel brand is {wheelBrand}");
    }
}