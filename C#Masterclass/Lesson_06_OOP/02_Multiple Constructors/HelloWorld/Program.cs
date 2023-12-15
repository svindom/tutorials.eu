using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    // A class in C# (and most other object-oriented programming languages)
    // is a blueprint for creating objects.
    // It defines a set of properties (data attributes)
    // and methods (functions) that an object of that class will have.

    internal class Program
    {
      static void Main(string[] args) 
        {
            Car myCar = new Car();
            myCar.Detail();

            Car audi = new Car("audi A4", 250);
            audi.Drive();
            audi.Detail();

            Car bmv= new Car("BMW M5", 350, "green"); 
            bmv.Drive();
            bmv.Detail();

            Console.WriteLine("Press \"1\" or \"2\" to stop the car!");

            string userInput = Console.ReadLine();
            if (userInput == "1" || userInput == "2")
            {
                audi.Stop();
            }
            else
            {
                Console.WriteLine("Car drives indefinetely");
            }
        }
    }
}