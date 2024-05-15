using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class ContractEmployee : Employee
    {
        private string _id;
        public double HourlyRate {get;}
        public override string EmployeeId => "CE"+_id;

        public override double Salary()
        {
            return HourlyRate * 160; //160 hour per month
        }
        public ContractEmployee(string name, double hourlyRate)
        : base(name)
    {
        _id = Guid.NewGuid().ToString(); // Generate a unique ID
        HourlyRate = hourlyRate;
    }
    }
}