using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aggregation
{
    public class Department
    {
        private List<Employee> employees; //Departemen berisi beberapa employee

        public Department() //Constructor membuat tipe employees menjadi arraylist
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee) //Membuat method menambahkan employee baru
        {
            employees.Add(employee);
        }
    }
}