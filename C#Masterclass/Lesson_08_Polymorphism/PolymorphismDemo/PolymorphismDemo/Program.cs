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

Console.WriteLine();

carBMW.SetCarIDInfo(12345, "Annika");
carBMW.GetCarIDInfo();

Console.WriteLine();

AnotherDumpBMW anotherDumpBMW = new AnotherDumpBMW(250, "white", "ggg3");
anotherDumpBMW.Repair();



Console.ReadKey();



public class Car
{
    public int HP { get; set; }
    public string Color { get; set; }
    
    // has a relationship
    protected CarIDInfo carIDInfo = new CarIDInfo();

    public void SetCarIDInfo (int idNum, string owner)
    {
        carIDInfo.IDNum = idNum;
        carIDInfo.Owner = owner;
    }

    public void GetCarIDInfo ()
    {
        Console.WriteLine($"The car has the ID of {carIDInfo.IDNum} and is owned by {carIDInfo.Owner}");
    }

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

// Derrived Class 1
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


// Derrived Class 2
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


// Derrived Class from derrived
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




// Has a

public class CarIDInfo
{
    // One way of declare property
    private int _idNum = 0; // Backing field with initializer
    public int IDNum
    {
        get
        {
            return _idNum;
        }
        set
        {
            _idNum = value; // 'value' is the value passed to the setter    
        }
    }

    // The same but more simple way to declare property
    public string Owner { get; set; } = "No owner";
}