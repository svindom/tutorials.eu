public class EmployeeList
{
    private List<Employee> _employees = new List<Employee>();
    public void AddEmployee(Employee employeesToAdd)
    {
        _employees.Add(employeesToAdd);
    }
    public void AddEmployee(params Employee[] employeesToAdd)
    {
        _employees.AddRange(employeesToAdd);
    }

    public List<Employee> GetEmployees()
    {
        return _employees;
    }

    public string GetEmployeeInfo(string employeeRole)
    {
        foreach (Employee employee in _employees)
        {
            if (employee.Role == employeeRole)
                return $"{employee.Name}, {employee.Role}, {employee.Salary}$";
        }
        return "There is no employee with this role";
    }

}





