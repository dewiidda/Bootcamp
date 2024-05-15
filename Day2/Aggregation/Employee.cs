using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aggregation
{
    public class Employee
    {
        private int id;
        private string name;

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void Work()
        {
            Console.WriteLine($"Employee {name} is working");
        }
    }
}