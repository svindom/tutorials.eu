using System.Security.Cryptography.X509Certificates;

namespace DelegatesDemo2
{
    internal class Program
    {
        // defining a delegate type called FilterDelegate that takes a person object and return a bool
        public delegate bool FilterDelegate(Person person);

        static void Main(string[] args)
        {
            Person person1 = new Person()
            {
                Name = "Katty",
                Age = 21,
            };
            Person person2 = new Person() { Name = "Lora", Age = 22 };
            Person person3 = new Person() { Name = "Karina", Age = 28 };
            Person person4 = new Person() { Name = "Kristina", Age = 33 };

            List<Person> list = new List<Person>() { person1, person2, person3, person4 };



            Console.ReadLine();
        }
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {

        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
