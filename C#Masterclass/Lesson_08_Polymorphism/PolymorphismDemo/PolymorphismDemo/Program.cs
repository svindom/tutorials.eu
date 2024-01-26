
Console.ReadKey();



public class Car
{
    public int HP { get; set; }
    public string Color { get; set; }

    public Car(int hp, string color)
    {
        HP = hp;
        Color = color;
    }

    public virtual void ShowDetails()
    {
        Console.WriteLine($"HP of a car is: {HP}\nthe color of the car is: {Color}");
    }

    public virtual void Repair()
    {
        Console.WriteLine("Car was repaired!");
    }
}

public class BMW : Car
{
    public string Model { get; set; }
    private string _brand;

    public BMW(int hp, string color, string model) : base(hp, color)
    {
        Model = model;
        _brand = "I don't care about dump car brands (For BMW)";
    }
    public override void ShowDetails()
    {
        Console.WriteLine($"HP of a BMW car is: {HP}\nthe color of the BMW car is: {Color}");
        Console.WriteLine(_brand);
    }

    public override void Repair()
    {
        Console.WriteLine("BMW Car was repaired!");
    }
}

public class Audi : Car
{
    public string Model { get; set; }
    private string _brand;

    public Audi(int hp, string color, string model) : base(hp, color)
    {
        Model = model;
        _brand = "I don't care about dump car brands (For Audi)";
    }
    public override void ShowDetails()
    {
        Console.WriteLine($"HP of a Audi car is: {HP}\nthe color of the Audi car is: {Color}");
        Console.WriteLine(_brand);
    }

    public override void Repair()
    {
        Console.WriteLine("Audi Car was repaired!");
    }
}