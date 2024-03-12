
namespace DelegatesDemo2
{
    internal class Program
    {
        // defining a delegate type called FilterDelegate that takes a person object and return a bool
        public delegate bool FilterDelegate(Person person);

        static void Main(string[] args)
        {
            // Creating 4 objects of the class "Person"
            Person person1 = new Person()
            {
                Name = "Katty",
                Age = 21,
            };
            Person person2 = new Person() { Name = "Lora", Age = 22 };
            Person person3 = new Person() { Name = "Karina", Age = 28 };
            Person person4 = new Person() { Name = "Kristina", Age = 33 };
            Person person5 = new Person() { Name = "Jhoanna", Age = 73 };

            // Adding them to the List
            List<Person> people = new List<Person>() { person1, person2, person3, person4, person5 };

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adults", people, IsAdult);
            DisplayPeople("Seniors", people, IsSenior);


            // Created a new variable called filter of type FilterDelegate
            // then we assigned an anonymous method to it instead of an already defined method

            FilterDelegate filter = delegate (Person person)
            {
                return person.Age >= 20 && person.Age <= 30;   
            };  // Important don't forget the : at the end because we are declaring a variable
                // and assigning it's value at the same time just like int x = 3;

            DisplayPeople("Between 20 and 30 years old", people, filter);

            // Anonymous delegate method
            DisplayPeople("All people", people, delegate (Person person) { return true; });


            // Statement Lambda
            // a search keyword to filter the names
            string searchKeyword = "a";
            DisplayPeople("Age over 20 with search keyword " + searchKeyword, people, (person) =>
            {
                if (person.Name.Contains(searchKeyword) && person.Age > 20)
                {
                    return true;
                }
                return false;
            });

            // Expession Lambda
            // here we are using expression lambda (one line of code)
            DisplayPeople("Exactly 25", people, (person) => person.Age == 25);

            Console.ReadLine();
        }

        // a method to display the list of people that passes the filter condition (returns true)
        // this method will take a title to be displayed, the list of people. and a filter delegate
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            // print the title
            Console.WriteLine($"Group of {title}:");
            Console.WriteLine("---------------------------------------------------");

            bool found = false; // this flag will indicate if any person meets the filter criteria

            foreach (Person person in people)
            {
                // check if this person passes the filter
                if (filter(person))
                {
                    Console.WriteLine($"{person.Name} is {person.Age} years old");
                    found = true;
                }
            }
            
            if (!found) // Check the flag after the loop
            {
                Console.WriteLine("There is no one with that age");
            }
            Console.WriteLine();
        }

        //================ FILTERS ================

        static bool IsMinor (Person person)
        {
            return person.Age < 18;
        }

        static bool IsAdult(Person person)
        {
            return person.Age >= 18;
        }

        static bool IsSenior (Person person)
        {
            return person.Age >= 65;
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
