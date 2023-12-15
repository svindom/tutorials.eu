using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");

            string temperature = Console.ReadLine();
            int numTemp = int.Parse(temperature);

            if (numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            }
            else if (numTemp == 20)
            {
                Console.WriteLine("Pants and Pu;; Over should be fine!");
            }
            else
            {
                Console.WriteLine("Shorts are enough today!");
            }

            Console.ReadKey();
            Console.WriteLine("Thanks!");
        }

    }
}