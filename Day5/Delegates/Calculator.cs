using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void Operation(int x, int y);
    public class Calculator
    {
        public static void Multiply(int x, int y)
        {
            (x * y).Dump();
        }
        public static void Add(int x, int y)
        {
            (x + y).Dump();
        }
    }
}