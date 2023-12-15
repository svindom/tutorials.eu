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
       //     myCar.Name = "MyAudiA3";
       //     myCar.Detail();

            Console.WriteLine(myCar.Name);
        }
    }
}