using static Audi;

List<Car> cars = new List<Car>()
{
    new Audi (200, "blue", "A4"),
    new BMW (350, "black", "M3")
};

foreach (var car in cars)
{
    car.Repair();
}

Console.WriteLine();

// as the class Car is a main class we can create it and make it equal to the BMW class which is a child class of it.
Car carBMW = new BMW(250, "white", "g3");
carBMW.ShowDetails();

AnotherDumpBMW anotherDumpBMW = new AnotherDumpBMW(250, "white", "ggg3");
anotherDumpBMW.Repair();

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
    private string _brand;
    public string Model { get; set; }

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

    public sealed override void Repair() // if it sealed it means that this method cannot be ovveriden in a next inherited class
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

    public class AnotherDumpBMW : BMW
    {
        public AnotherDumpBMW(int hp, string color, string model) : base(hp, color, model)
        {

        }

        // this method can't be ovveriden as it sealed in the base class 
        /*
        public override void Repair()
        {
            base.Repair();
        }
        */
    }
}