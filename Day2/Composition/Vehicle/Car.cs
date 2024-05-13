using Automotive;

namespace Vehicle;

public class Car
{
    public string color;
    public string brand;
    public int numDoor;
    public Engine engine;
    public Wheel wheel;
    public Speed speed;

    public Car(
        string color, 
        string brand, 
        int numDoor, 
        Engine engine, 
        Wheel wheel, 
        Speed speed)
    {
        this.color = color;
        this.brand = brand;
        this.numDoor = numDoor;
        this.engine = engine;
        this.wheel = wheel;
        this.speed = speed;
    }

    public void PrintAtrribute(
        string color, 
        string brand, 
        int numDoor )
        {
            Console.WriteLine($"Car color:{color}");
            Console.WriteLine($"Car brand:{brand}");
            Console.WriteLine($"Car number of door:{numDoor}");
        }
}