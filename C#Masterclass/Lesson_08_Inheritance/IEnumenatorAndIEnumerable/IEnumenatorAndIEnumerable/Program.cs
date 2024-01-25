// 1.IEnumerable <T> for generic colections
// 2.IEnumerable for non generic collections

// IEnurable<T> contains a single method that you must implement when implementing this interface =>
// GetEnumenator(), which returns an IEnumenator object.
// The returned IEnurable<T> provides the ability to iterate through the collection by
// exposing a Current property that points at the object we are currently at in the collection.

using System.Collections;

DogShelter dogShelter = new DogShelter();

foreach(Dog dog in dogShelter)
{
    if (!dog.IsNaughtyDog)
    {
        dog.GiveTreat(5);
    }
    else
    {
        dog.GiveTreat(3);
    }
}





Console.ReadKey();

class Dog
{ 
    public string Name { get; set; }
    public bool IsNaughtyDog { get; set; }

    public Dog(string name, bool isNaughtyDog)
    {
        Name = name;
        IsNaughtyDog = isNaughtyDog;
    }

    public void GiveTreat(int numberOfTreats)
    {
        Console.WriteLine($"Dog {Name} said \'Wuoff\' {numberOfTreats} times!");
    }

}

class DogShelter : IEnumerable<Dog>
{
    public List<Dog> Dogs;

    public DogShelter()
    {
        Dogs = new List<Dog>()
        {
            new Dog("Casper", false),
            new Dog("Sif", false),
            new Dog("Oreo", false),
            new Dog("Pixel", false)
        };
    }

    public IEnumerator<Dog> GetEnumerator()
    {
        return ((IEnumerable<Dog>)Dogs).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)Dogs).GetEnumerator();
    }
}
