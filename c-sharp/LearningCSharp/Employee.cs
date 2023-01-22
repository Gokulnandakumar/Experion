using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LearningCSharp
{
    internal class Employee
    {
        public string EmpName;
        public int EmpId;
        public int EmployeeSalary;

        public void Display()
        {
            Console.WriteLine($"Name of Employee is {EmpName}");
            Console.WriteLine($"Salary of Employee is {EmployeeSalary}");
        }
    }
}
