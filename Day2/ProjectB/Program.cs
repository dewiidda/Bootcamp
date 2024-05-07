using Automotive;
using Kitchen;
using Vehicle;

class Program
{
    static void Main()
    {
        Engine engine = new Engine(1200,"Supra",2023,"Toyota");
        Vehicle.Wheel wheel = new Vehicle.Wheel("Offroad",40,"Dunlop");
        Speed speed = new Speed(100.0f);
        Car car = new Car("Black","Toyota",2,engine, wheel, speed);

        // wheel.PrintAtrribute(wheel.wheelType, wheel.wheelDiameter, wheel.wheelBrand);
        wheel.PrintAtrribute();
        car.PrintAtrribute(car.color, car.brand, car.numDoor);

        Cake cake = new Cake("Rose brand");



    }
}