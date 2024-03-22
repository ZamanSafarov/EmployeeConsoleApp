using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleApp
{
    public class Department
    {
        Employee[] Employees = new Employee[] { };

        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);

            Employees[Employees.Length-1] = employee;
        }
        public void ShowEmployeeInfo()
        {
            foreach (Employee emp in Employees) {
                Console.WriteLine($"Name: {emp.Name}\nSurname: {emp.Surname}\nAge: {emp.Age}\nDepartmentName:{emp.DepartmentName}\nSalary: {emp.Salary}");
                Console.WriteLine("---------------------------------------------------------------------------------------");
            }

        }
        public Employee[] GetAllEmployees()
        {
            return Employees;
        }
        public void GetAllEmployeesBySalary(int minSalary, int maxSalar)
        {
            if (Employees.Length !=0 )
            {
                foreach (Employee emp in Employees)
                {
                    if (emp.Salary > minSalary && emp.Salary < maxSalar)
                    {
                        Console.WriteLine($"Name: {emp.Name}\nSurname: {emp.Surname}\nAge: {emp.Age}\nDepartmentName:{emp.DepartmentName}\nSalary: {emp.Salary}");
                        Console.WriteLine("---------------------------------------------------------------------------------------");

                    }
                    else
                    {
                        Console.WriteLine("Bu maaş aralığında işçi yoxdur!!");
                        break;
                    }

                }
            }
            else
            {
                Console.WriteLine("Işçi yoxdur!!");
            }
            
                
          
        }
    }
}
