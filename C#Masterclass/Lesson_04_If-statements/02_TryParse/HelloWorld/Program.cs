using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");

            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            if(int.TryParse(temperature, out number))
            {
                numTemp= number;
            }
            else 
            {
                numTemp= 0;
                Console.WriteLine("Value entered, was no number. 0 set as temperature");
            }

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