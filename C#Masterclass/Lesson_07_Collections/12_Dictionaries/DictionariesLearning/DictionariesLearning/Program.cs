using System.Collections.Generic;

Employee[] emploees = { 
    new Employee("CEO", "Gwyn", 45, 200),
    new Employee("Manager","Joe", 35, 150),
    new Employee("HR", "Lora", 24, 95),
    new Employee("Secretary", "Petra", 27, 90),
    new Employee("Lead Developer", "Arthur", 58, 180),
    new Employee("Intern", "Ernest", 22, 20)
};

Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
foreach (Employee emploee in emploees)
{
    employeesDirectory.Add(emploee.Role, emploee);
}

string key = "CEO";
if (employeesDirectory.ContainsKey(key))
{
    Employee employeeInfo = employeesDirectory[key];
    Console.WriteLine($"{employeeInfo.Name}, {employeeInfo.Role}, {employeeInfo.Salary}$");
}
else
{
    Console.WriteLine($"No emploee founf with this key {key}");
}

Console.ReadKey();




