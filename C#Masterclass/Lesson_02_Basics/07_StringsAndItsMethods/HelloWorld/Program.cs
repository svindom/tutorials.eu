using System;

namespace HelloWorld // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string here : ");
            //Read first input string.
            string input = Console.ReadLine();

            Console.Write("Enter a character to search: ");
            //Read the character input to search.
            char searchInput = Console.ReadLine()[0];  //because we asking to have a char thats why we specify the first character [0].

            //Gets the Index of the character from the string.
            int searchIndex = input.IndexOf(searchInput);
            //Prints the Index as a search result on console.
            Console.WriteLine($"Index of character {searchInput} in string is {searchIndex}");

            Console.Write("Enter first name: ");
            //Read the first name
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            //Read the last name
            string lastName = Console.ReadLine();

            //Concatinate the firstName and lastName variables and assign that to fullName variable.
            string fullName = string.Concat(firstName, "", lastName); 
            Console.WriteLine($"Your full name is {fullName}");

        }

    }
}