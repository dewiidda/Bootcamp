using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class PermanentEmployee : Employee
    {
        private string _id;
        public override string EmployeeId => "PE"+_id;
        public double monthlySalary { get;}
        public override double Salary()
        {
            return monthlySalary;
        }

        public PermanentEmployee(string name, double monthlySalary):base(name)
        {
            _id = Guid.NewGuid().ToString();
            this.monthlySalary = monthlySalary;
        }
    }
}