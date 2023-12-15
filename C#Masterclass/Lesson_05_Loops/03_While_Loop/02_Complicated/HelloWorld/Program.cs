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
            // The idea of the exercise is that while you press enter button it always adds +1 to the following line until you press any symbol to stop the loop.

            int counter = 0;
            string enteredText = "";
            while (String.IsNullOrEmpty(enteredText)) // '.Equals' is the same as '==' operator but with strings we use. But here I desided to chanch it to: String.IsNullOrEmpty(enteredText)
            {
                Console.WriteLine("Please press enter to increase amount by one and anything else" +
                    " enter any key if you want to finish counting");
                counter++;
                enteredText = Console.ReadLine();
                Console.WriteLine($"Current people is {counter}");
            }
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine($"{counter} people inside the bus. Press enter twice to close the program");
            Console.Read();
        }
    }
}