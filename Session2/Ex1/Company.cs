using System.Collections.Generic;
using System.Linq;

namespace Ex1
{
    public class Company
    {

        public List<Employee> Employees { get; set; } = new();

        public double GetMonthlySalaryTotal()
        {
            return Employees.Sum(employee => employee.GetMonthlySalary());
        }

        public void HireNewEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        
    }
}