public class EmployeeModifier
{
    public void CheckIfContainsKey(Dictionary<string, Employee> employeesDictionary, string employeeKey)
    {
        if (employeesDictionary.ContainsKey(employeeKey))
        {
            Employee employeeInfo = employeesDictionary[employeeKey];
            Console.WriteLine($"{employeeInfo.Name}, {employeeInfo.Role}, {employeeInfo.Salary}$");
        }
        else
        {
            Console.WriteLine($"No employee found with this key {employeeKey}");
        }
    }
    public void UpdateEmployee(Dictionary<string, Employee> employeesDictionary, string employeeKey)
    {
        if (employeesDictionary.ContainsKey(employeeKey))
        {
            // replace the employee
            employeesDictionary[employeeKey] = new Employee("HR", "Eleka", 26, 98);
            // Get the new employee info
            Employee newEmployeeInfo = employeesDictionary[employeeKey];
            //print a new employee info
            Console.WriteLine($"A new HR is {newEmployeeInfo.Name}, {newEmployeeInfo.Role}, {newEmployeeInfo.Salary}$");
        }
        else
        {
            Console.WriteLine($"No employee found with this key {employeeKey}");
        }
    }


    public void RemoveEmployee(Dictionary<string, Employee> employeesDictionary, string employeeKey)
    {
        if (employeesDictionary.ContainsKey(employeeKey))
        {
            employeesDictionary.Remove(employeeKey);
            Console.WriteLine($"Employee with role {employeeKey} has been removed.");
        }
        else
        {
            Console.WriteLine($"No employee found with this key {employeeKey}");
        }
    }


    public void PrintAllEmployee(Dictionary<string, Employee> employeesDictionary)
    {
        for (int i = 0; i < employeesDictionary.Count; i++)
        {
            //using ElementAt(i) to return the key-value pair stored at index i
            KeyValuePair<string, Employee> keyValuePair = employeesDictionary.ElementAt(i);
            //print the key
            Console.WriteLine($"Key: {keyValuePair.Key}");
            Console.WriteLine($"The serial number is: {i}");

            //storing the value in an employeeobject
            Employee employeeValue = keyValuePair.Value;
            //printing the properties of the employee object
            Console.WriteLine($"Employee Name: {employeeValue.Name}");
            Console.WriteLine($"Employee Role: {employeeValue.Role}");
            Console.WriteLine($"Employee Age: {employeeValue.Age}");
            Console.WriteLine($"Employee Salary: {employeeValue.Salary}");
        }
    }

    public void GetValueEmployeeIntern(Dictionary<string, Employee> employeesDictionary)
    {
        Employee result = null;
        // using TryGetValue() it returns true if the operation was successful and false otherwise
        if (employeesDictionary.TryGetValue("Intern", out result))
        {
            Console.WriteLine("Value Retrieved!");

            Console.WriteLine($"Employee Name: {result.Name}");
            Console.WriteLine($"Employee Role: {result.Role}");
            Console.WriteLine($"Employee Age: {result.Age}");
            Console.WriteLine($"Employee Salary: {result.Salary}");
        }
        else
        {
            Console.WriteLine("The key does not exist");
        }

    }
}



