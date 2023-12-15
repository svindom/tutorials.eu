using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {   // Key - Value
        // Auto - Car

        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Lora", 32, 21),
                new Employee("Secretary", "Petra", 28,18),
                new Employee("Art director", "Jane", 55, 35),
                new Employee("Developer", "Nanja", 22, 8),
            };
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" }
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Name, emp);
            }

        }
    }
    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        // Yearly Salary = rate/h * number of days * numbers of weeks * number of months
        public float Salary
        {
            get 
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        public Employee(string role, string name, int age, float rate) 
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = Rate;
        }

    }
}
