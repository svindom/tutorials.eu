﻿public class Employee
{
    // Properties
    public string Role { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public float Rate { get; set; }

    // Yearly Salary = rate/h * number of days * number of weeks * number of month
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
        this.Rate = rate;

    }
}
