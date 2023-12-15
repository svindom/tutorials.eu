using System;


namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            int age = 19;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            // We can do the same just using if statement like in the example below

            if (age == 15)
            {
                Console.WriteLine("Too young to party in the club!");
            }
            else if (age == 25)
            {
                Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("How old are you then?");
            }

            // we can use switch with strings as well

            string username = "Alex";

            switch (username)
            {
                case "Alex":
                    Console.WriteLine("user name is Alex");
                    break;
                case "root":
                    Console.WriteLine("user name is root");
                    break;
                default:
                    Console.WriteLine("user name is unknown");
                    break;
            }


        }
    }
}