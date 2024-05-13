using System;

    public class GenericClass<T1,T2>
    {
        public T1 Message;
        public void GenericMethod(T1 Name, T1 Location, T2 Age)
        {
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Location: {Location}");
            Console.WriteLine($"Age: {Age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate GenericClass, string is the type argument
            GenericClass<string,int> myGenericClass = new GenericClass<string,int>
            {
                Message = "Welcome to Bootcamp"
            };
            myGenericClass.GenericMethod("Dewi Idda", "Salatiga",25);
        }
    }