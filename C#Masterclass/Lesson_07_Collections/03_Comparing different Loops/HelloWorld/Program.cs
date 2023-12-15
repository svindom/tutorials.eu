using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace HelloWorld
{

    internal class Program
    {
      static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            // use for each, when you need to perform an operation on each element in a collection and
            // you don't need to manipulate the index

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("-----------------------------------------------------");

            // use for when you need more control over the iteration process,
            // like skipping elements or iterating in reverse

            for (int i = 0; i < numbers.Length; i+=2 )
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("-----------------------------------------------------");

            // use while when you don't know how many times you
            // need to loop

            string input;
            do
            {
                Console.WriteLine("Please enter a valid number:");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out _)); // underscore means that it can be any integer value
        }
    }
}