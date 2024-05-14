using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic
{
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
    
}