using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public abstract class Employee //using keyword abstract
    {
        public string Name { get; set; }
        public abstract string EmployeeId { get;}

        public abstract double Salary();

        public double MedicalCoverage()
        {
            return 200000; //medical coverage for all employee
        }

        public Employee(string name)
        {
            Name = name;
        }

    }
}