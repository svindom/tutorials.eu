

Console.ReadKey();

public class Employee
{
    public string Name { get; set; }
    public string FirstName { get; set; }
    public int Salary { get; set; }

    // Default constructor
    /*
    public Employee()
    {
        this.Name = "There is no employee name";
        this.FirstName = "There is no employee name";
        this.Salary = 0;
    }
    */

    public Employee(string name, string firstName, int salary)
    {
        this.Name = name;
        this.FirstName = firstName;
        this.Salary = salary;
    }

    public virtual void Work()
    {
        
    }
    public void Pause()
    {

    }
}

public class Boss : Employee
{
    public string CompanyCar { get; set; }

    public Boss(string name, string firstName, int salary, string companyCar) : base(name, firstName, salary)
    {
        this.Name = name;
        this.FirstName = firstName;
        this.Salary = salary;

        this.CompanyCar = companyCar;
    }

    public void Lead()
    {

    }
}

public class Trainee : Employee
{
    public int WorkingHours { get; set; }
    public int SchoolHours { get; set; }

    public Trainee (string name, string firstName, int salary, int workingHours, int schoolHours) : base (name, firstName, salary)
    {
        this.Name = name;
        this.FirstName = firstName;
        this.Salary = salary;

        this.WorkingHours = workingHours;
        this.SchoolHours = schoolHours;
    }
    
    public void Learn()
    {

    }
}
