using System;


int employeeSalary = 3000;
int bossSalary = 8000;
int traineeSalary = 1200;
int traineeWorkingHours = 4;
int traineeStudingHours = 4;


Employee jacky = new Employee("UI designer", "Jacky", employeeSalary);
Boss harris = new Boss("CEO", "Harris", bossSalary, "BMW");
Trainee yutta = new Trainee("Programmer trainee", "Yutta", traineeSalary, traineeWorkingHours, traineeStudingHours);

jacky.Work();
jacky.Pause();
Console.WriteLine("----------------------------------------");
harris.Lead();
harris.Work();
harris.Pause();
Console.WriteLine("----------------------------------------");
yutta.Learn();
yutta.Work();
yutta.Pause();



Console.ReadKey();

public class Employee
{
    public string Position { get; }
    public string FirstName { get; }
    public int Salary { get; }

    // Default constructor
    /*
    public Employee()
    {
        this.Name = "There is no employee name";
        this.FirstName = "There is no employee name";
        this.Salary = 0;
    }
    */

    public Employee(string position, string firstName, int salary)
    {
        this.Position = position;
        this.FirstName = firstName;
        this.Salary = salary;
    }

    public virtual void Work()
    {
        Console.WriteLine($"{FirstName} is saying \"I'm working\"");
    }
    public void Pause()
    {
        Console.WriteLine($"{FirstName} is saying \"I'm having a break\"");
    }
}

public class Boss : Employee
{
    public string CompanyCar { get; set; }

    public Boss(string position, string firstName, int salary, string companyCar) : base (position, firstName, salary) // : base - gives us the possibility of not rewriting the constructor from the main class
    {
        this.CompanyCar = companyCar;
    }

    public void Lead()
    {
        Console.WriteLine($"{FirstName} is saying \"I'm a CEO of the company\"");
    }
}

public class Trainee : Employee
{
    public int WorkingHours { get; set; }
    public int SchoolHours { get; set; }

    public Trainee (string position, string firstName, int salary, int workingHours, int schoolHours) : base (position, firstName, salary) // : base - gives us the possibility of not rewriting the constructor from the main class
    {
        this.WorkingHours = workingHours;
        this.SchoolHours = schoolHours;
    }
    
    public void Learn()
    {
        Console.WriteLine($"{FirstName} is saying \"I'm a trainee here and I'm studing for {SchoolHours} hours at school\"");
    }
    public override void Work()
    {
        Console.WriteLine($"{FirstName} is saying \"I'm a trainee here and I'm working for {WorkingHours} hours at the company.\"");
    }
}
