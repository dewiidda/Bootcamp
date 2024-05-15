/*
Consider an organization that has both permanent employees and contract employees. 
Both types of employees share common information such as employee name and employee ID. 
Instead of repeating this information, we can create an abstract class called Employee with common properties like Name and Id. 
The employee’s salary calculation may vary based on the type of employee (permanent or contract). 
We can let the PermanentEmployee and ContractEmployee classes provide custom logic for calculating the salary.
*/

using Abstract_Class;

class Program
{
	static void Main()
	{
		var permanentEmp = new PermanentEmployee("Jennie", 400000000000);
		var contractEmp = new ContractEmployee("Fadl", 1);

	}
}