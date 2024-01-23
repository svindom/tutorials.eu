

Table table = new Table("white", "wood");


Console.WriteLine($"This is my {table.Color} table and it has {table.Material} material");
Console.ReadKey();




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


class Chair : Furniture
{
    
    public Chair(string color, string material) :base (color, material)
    {

    }
    
}

class Table : Furniture
{
    
    public Table (string color, string material) : base (color, material)
    {

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

class Car : Vehicle
{
    public Car(float speed, string color) :base (speed, color) 
    {

    }
}