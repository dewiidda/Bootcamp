using Inheritance;
internal class Program
{
    private static void Main(string[] args)
    {
        Animal animal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        animal.Eat();
        dog.Bark();
        cat.Meow();
    }
}