using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate float MyDelegate(int a, int b);

    public class Subscriber
    {
        public float Add(int a, int b)
        {
            return (a+b);
        }

        public float Mul(int a, int b)
        {
            return (a*b);
        }
    }
}