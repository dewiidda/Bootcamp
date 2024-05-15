using System.Collections.Generic;
using Aggregation;

/*
Aggregation represents a weaker relationship between two classes, where one class uses the other.
In aggregation:
The aggregated object (the used object) can exist independently of the aggregator object.
When the aggregator object is destroyed, the aggregated object can still exist.
*/

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