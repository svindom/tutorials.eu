using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Alex Z"; 
            string friend2 = "Dima";
            string friend3 = "Alex P";

            GreetFriend(friend1, friend2, friend3);
            Console.Read();
        }

        public static void GreetFriend(string friendName, string friendName2, string friendName3)
            {
                Console.WriteLine("Hi " + friendName + " , my friend!");
                Console.WriteLine("Hi " + friendName2 + " , my friend!");
                Console.WriteLine("Hi " + friendName3 + " , my friend!");
        }


    }
}