using System.Collections.Generic;

EmployeeList employeeList = new EmployeeList();
EmployeeModifier employeeModifier = new EmployeeModifier();

employeeList.AddEmployee(
    new Employee("CEO", "Gwyn", 45, 200),
    new Employee("Manager", "Joe", 35, 150),
    new Employee("HR", "Lora", 24, 95),
    new Employee("Secretary", "Petra", 27, 90),
    new Employee("Lead Developer", "Arthur", 58, 180),
    new Employee("Intern", "Ernest", 22, 20)
    );

Dictionary<string,Employee> employeesDictionary = new Dictionary<string, Employee>();
foreach(Employee employee in employeeList.GetEmployees())
{
    employeesDictionary.Add(employee.Role, employee);
}



employeeModifier.CheckIfContainsKey(employeesDictionary, "HR");
employeeModifier.PrintAllEmployee(employeesDictionary);

Console.WriteLine("----------------------------------------------------------------------------------");

employeeModifier.UpdateEmployee(employeesDictionary, "HR");
employeeModifier.PrintAllEmployee(employeesDictionary);

Console.WriteLine("----------------------------------------------------------------------------------");

employeeModifier.GetValueEmployeeIntern(employeesDictionary);

Console.WriteLine("----------------------------------------------------------------------------------");

employeeModifier.RemoveEmployee(employeesDictionary, "Intern");
employeeModifier.PrintAllEmployee(employeesDictionary);




Console.ReadKey();

