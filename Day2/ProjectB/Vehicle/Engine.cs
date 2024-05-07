namespace Vehicle;

public class Engine
{
    public int engineHP;
    public string engineType;
    public int engineYear;
    public string engineBrand;

    public Engine(
        int engineHP, 
        string engineType, 
        int engineYear, 
        string engineBrand)
    {
        this.engineHP = engineHP;
        this.engineType = engineType;
        this.engineYear = engineYear;
        this.engineBrand = engineBrand;
    }

    public void PrintAtrribute()
    {
        Console.WriteLine($"Engine Horse Power: {engineHP}");
        Console.WriteLine($"Engine Type: {engineType}");
        Console.WriteLine($"Engine Year: {engineYear}");
        Console.WriteLine($"Engine Brand: {engineBrand}");
    }
}