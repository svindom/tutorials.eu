

Table table = new Table("white", "wood");
Chair chair = new Chair("Yellow", "wood");

Car car = new Car(80f, "Green");

car.DestroyableObjectsNearby.Add(table);
car.DestroyableObjectsNearby.Add(chair);

car.Destroy();

Console.ReadKey();



interface IDestroyable 
{
    // Interfaces have only properies and methods.

    // property to store the audio file of the destruction sound
    public string DestuctionSound { get; set; }

    // method to destroy an object
    public void Destroy();
}



class Furniture
{
    public string Color { get; set;}
    public string Material { get; set; }

    
    public Furniture(string color, string material)
    {
        Color = color;
        Material = material;
    }

    public Furniture() 
    {
        Color = "White";
        Material = "Wood";
    }
    
}


class Chair : Furniture, IDestroyable
{
    public string DestuctionSound { get; set; }

    public Chair(string color, string material) :base (color, material)
    {
        DestuctionSound = "ChairDestructionSound.MP3";
    }
    
    public void Destroy()
    {
        Console.WriteLine($"Playing destruction sound {DestuctionSound}");
        Console.WriteLine("Spawning the chair parts ");
        Console.WriteLine($"The {Material} {Color} chair was destroyed ");
    }
}

class Table : Furniture, IDestroyable
{
    public string DestuctionSound { get; set; }
    public Table (string color, string material) : base (color, material)
    {
        DestuctionSound = "TableDestructionSound.MP3";
    }
    public void Destroy()
    {
        Console.WriteLine($"Playing destruction sound {DestuctionSound}");
        Console.WriteLine("Spawning the table parts ");
        Console.WriteLine($"The {Material} {Color} table was destroyed ");
    }
}

class Vehicle
{
    public float Speed { get; set; }
    public string Color { get; set; }

    public Vehicle(float speed, string color)
    {
        Speed = speed;
        Color = color;
    }

    public Vehicle() 
    {
        Speed = 120f;
        Color = "Black";
    }
}

class Car : Vehicle, IDestroyable
{
    public string DestuctionSound { get; set; }

    // Creating a new  property tp store the destroyable objects nearby when a car gets destroyed it should also
    // destroy the nearby object
    // This list is of typy IDestroyable which means it can store any object that mplements this interface and we 
    // can only access the properties and methods in this interface.
    public List<IDestroyable> DestroyableObjectsNearby;

    public Car(float speed, string color) :base (speed, color) 
    {
        // initialize the interface's property with a value in the constructor
        DestuctionSound = "CarExplosionsOUND.MP3";

        // initialize the list of destroyable objects
        DestroyableObjectsNearby = new List<IDestroyable>();
    }

    // implementing the interface's method
    public void Destroy()
    {
        // when a car gets destroyed we should play the destruction sound and create a fire effect
        Console.WriteLine($"Playing destruction sound {DestuctionSound}");
        Console.WriteLine("Create fire effect");

        // go through each destroyable object nearby and call it's destroy method
        foreach(IDestroyable destroyable in DestroyableObjectsNearby)
        {
            destroyable.Destroy();
        }
    }
}