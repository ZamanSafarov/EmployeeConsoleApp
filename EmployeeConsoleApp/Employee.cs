using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleApp
{
    public class Employee
    {
        public Employee(string name,string surname,byte age,string departmentNo,int salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            DepartmentName = departmentNo;
            Salary = salary;

        }
        public string Name;
        public string Surname;
        public byte Age;
        public string DepartmentName;
        public int Salary;
    }
}
