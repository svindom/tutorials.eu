using System.Collections.Generic;

EmployeeDirectory employeeDirectory = new EmployeeDirectory();
employeeDirectory.AddEmployee(
    new Employee("CEO", "Gwyn", 45, 200),
    new Employee("Manager", "Joe", 35, 150),
    new Employee("HR", "Lora", 24, 95),
    new Employee("Secretary", "Petra", 27, 90),
    new Employee("Lead Developer", "Arthur", 58, 180),
    new Employee("Intern", "Ernest", 22, 20)
    );

Dictionary<string,Employee> employeesDictionary = new Dictionary<string, Employee>();
foreach(Employee employee in employeeDirectory.GetEmployees())
{
    employeesDictionary.Add(employee.Role, employee);
}


string key = "CEO";
if (employeesDictionary.ContainsKey(key))
{
    Employee employeeInfo = employeesDictionary[key];
    Console.WriteLine($"{employeeInfo.Name}, {employeeInfo.Role}, {employeeInfo.Salary}$");
}
else
{
    Console.WriteLine($"No emploee founf with this key {key}");
}

Console.ReadKey();





