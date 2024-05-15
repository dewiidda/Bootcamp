using Automotive;
using Kitchen;
using Vehicle;


/*
Composition represents a strong ownership relationship between two classes, where one class owns the other.
In composition:
The composed object (the owned object) cannot exist independently of the owner object.
When the owner object is destroyed, the composed object is also destroyed.
*/
class Program
{
    static void Main()
    {
        Engine engine = new Engine(1200,"Supra",2023,"Toyota");
        Wheel wheel = new Wheel("Offroad",40,"Dunlop");
        Speed speed = new Speed(100.0f);
        Car car = new Car("Black","Toyota",2,engine, wheel, speed);

        // wheel.PrintAtrribute(wheel.wheelType, wheel.wheelDiameter, wheel.wheelBrand);
        wheel.PrintAtrribute();
        car.PrintAtrribute(car.color, car.brand, car.numDoor);

        Cake cake = new Cake("Rose brand");



    }
}