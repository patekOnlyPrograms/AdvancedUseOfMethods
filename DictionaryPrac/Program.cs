using System.Collections;

namespace DictionaryPrac;

public class Program
{
    public static void Main(string[] args)
    {
        var employees = new List<Employee>()
        {
            new Employee("Jake Smith", "Space", 25000),
            new Employee("Susan Smith", "HR", 20000),
            new Employee("Ben Roberto", "Mechanics", 100000),
        };

        CalculateAverageSalaryPerDepartment(employees);
        
        Dictionary<string,decimal> CalculateAverageSalaryPerDepartment(IEnumerable<Employee> employees)
        {
            //Store each employee in its own department 
            var employeesPerDepartments = new Dictionary<string, List<Employee>>();
            foreach (var employee in employees)
            {
                if (!employeesPerDepartments.ContainsKey(employee.Department))
                {
                    employeesPerDepartments[employee.Department] = new List<Employee>();
                }
                employeesPerDepartments[employee.Department].Add(employee);
            }

            
            //each key value in the new dictionary 
            var result = new Dictionary<string, decimal>();
            
            foreach (var employeesPerDepartment in employeesPerDepartments)
            {
                decimal sumOfSalaries = 0;
                foreach (var employee in employeesPerDepartment.Value)
                {
                    sumOfSalaries += employee.MonthlySalary;
                }   

                var average = sumOfSalaries / employeesPerDepartment.Value.Count;

                result[employeesPerDepartment.Key] = average;
            }
            
            return result;
        }
    }


    public class Employee
    {
        public Employee(string name, string department, decimal monthlySalary)
        {
            Name = name;
            Department = department;
            MonthlySalary = monthlySalary;
        }

        public string Name { get; init; }
        public string Department { get; init; }
        public decimal MonthlySalary { get; init; }
    }
}