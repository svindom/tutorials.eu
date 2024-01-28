List <Shape> shapes = new List<Shape> ()
{
    new Cube(4),
    new Sphere(3)
};

foreach (var shape in shapes)
{
    shape.GetInfo();
    Console.WriteLine($"{shape.Name} has a volume of {shape.Volume()}");
}

Console.ReadKey();


public abstract class Shape
{
    public string Name { get; set; }

    public virtual void GetInfo()
    {
        Console.WriteLine($"This is a {Name}");
    }
    public abstract double Volume();
}

public class Cube : Shape
{
    const int PowerOfSize = 3;

    public double Length { get; set; }

    public Cube(double length)
    {
        Name = "Cube";
        Length = length;
    }
    public override double Volume()
    {
        return Math.Pow(Length, PowerOfSize);
    }

    public override void GetInfo() 
    {
        base.GetInfo();
        Console.WriteLine($"The {Name} has a length of {Length}");
    }
}


public class Sphere : Shape
{
    const int PowerOfSize = 3;

    public double Radious { get; set; }

    public Sphere(double radious)
    {
        Name = "Sphere";
        Radious = radious;
    }
    public override double Volume()
    {
        return Math.PI * (Math.Pow(Radious, PowerOfSize)) *4/3;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"The {Name} has a radious of {Radious}");
    }
}