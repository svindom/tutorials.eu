using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    class Program
    {
      static void Main(string[] args) 
        {
            int inputTemperature = 0;
            string temperatureMessage = string.Empty;
            string inputValue = string.Empty;

            // take input from console
            Console.Write("Enter the current temperature : ");
            inputValue = Console.ReadLine();

            // validate the inputas valid input integer value
            bool validInteger = int.TryParse(inputValue, out inputTemperature);

            if (validInteger)
            {
                // if is valid integer then it will check for the condition using nes
                temperatureMessage = inputTemperature <= 15 ? "it is too cold here" : (inputTemperature >= 16 && inputTemperature <= 28) ? "it is cold here" : inputTemperature > 28 ? "it is hot here" : "";
                Console.WriteLine(temperatureMessage);
            }
        }
    }
}