using System;
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