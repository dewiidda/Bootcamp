
using System.Collections.Generic;
using Aggregation;
internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee = new Employee(32,"Dora");
        Department traveling = new Department();
        traveling.AddEmployee(employee);
        employee.Work();

    }
}