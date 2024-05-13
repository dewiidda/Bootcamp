//Cat is a concrete class, because we can intantiate an object of this class use 'new' keyword
class Program //if there is no access modifier in class, the default is internal
{
    static void Main()
    {
        Cat cat = new Cat(); //instantiate class 'Cat' into object 'cat'
        cat.Eat();
    }
}

class Cat
{
    string color;
    string species;
    int age;

    public void Eat()
    {
        Console.WriteLine("Cat eat");
    }
}