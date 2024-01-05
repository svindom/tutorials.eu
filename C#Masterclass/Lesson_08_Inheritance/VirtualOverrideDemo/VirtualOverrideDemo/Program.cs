Dog myDog = new Dog("Charly", 8);
Console.WriteLine($"{myDog.Name} is {myDog.Age} years old");
myDog.Play();
myDog.Eat();
myDog.MakeSound();




Console.ReadKey();





// Base class
public class Animal
{
    // properties
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsHungry { get; set; }

    // constructor
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
        // in our case all animals are hungry by default
        IsHungry = true;
    }

    // an empty virtual method MakeSound for other classes to override
    public virtual void MakeSound()
    {
        
    }

    // a virtual method which sub classes (children or derived) can override
    public virtual void Eat()
    {
        if (IsHungry)
        {
            Console.WriteLine($"The {Name} is eating");
        }
        else
        {
            Console.WriteLine($"The {Name} is happy and doesn't want to eat");
        }
    }

    public virtual void Play()
    {
        Console.WriteLine($"The {Name} is plaing");
    }
}

// Child class
class Dog : Animal
{
    // bool property to check if the dog is happy
    public bool IsHappy { get; set; }

    // as we are inheriating from the Animal class we must to create a simple constructor 
    // where we pass the name and age to our base constructor, specifically Animal.
    public Dog( string name, int age) : base( name, age ) 
    {
        IsHappy = true;
    }

    // simple override (just reuse the same logic) of the virtual method Eat from the base class Animal
    public override void Eat()
    {
        // to call the Eat method from the base class we use keyword "base".
        base.Eat();
    }

    // override of the virtual method MakeSound
    public override void MakeSound()
    {
        Console.WriteLine("Bau bau bau");
    }

    // override of the virtual method Play
    public override void Play()
    {
        // check if the dog is happy if yes call the Play method from the base class Animal
        if(IsHappy)
        {
            base.Play();
        }
        else
        {
            Console.WriteLine("Make your pet be happy!");
        }
    }
}