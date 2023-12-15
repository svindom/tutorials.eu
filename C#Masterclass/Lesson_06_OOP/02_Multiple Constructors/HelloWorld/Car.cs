using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Car
    {
        // Member Variables
        private string _name; // private field typically used for storing data.
        private int _hp;      // horse power
        private string _color;

        // Default Constructor
        public Car ()
        {
            _name = "Car";
            _hp = 0;    
            _color= "red";  
        }

        // Partial Specification Constructor
        public Car(string name, int hp = 0)
        {
            _name = name;
            _hp = hp;
            _color = "blue";
            Console.WriteLine(name + " was created");
        }

        // Full Specification Constructor
        public Car(string name, int hp = 0, string color = "black")
        {
            _name = name;
            _hp = hp;
            _color = color;
            Console.WriteLine(name + " was created");
        }

        // Member Methods
        public void Drive()
        {
            Console.WriteLine(_name + " is driving");
        }
        public void Stop()
        {
            Console.WriteLine(_name + " stopped!");
        }
        public void Detail()
        {
            Console.WriteLine("The car name is " + _name + " and the car horse power is " + _hp + " the color of the car is " + _color);
        }

    }
}
