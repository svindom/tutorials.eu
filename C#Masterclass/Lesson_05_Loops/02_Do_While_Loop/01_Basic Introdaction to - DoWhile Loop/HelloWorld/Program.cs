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
            int counter = 0;
            do
            {
                Console.WriteLine(counter);
                counter++; // if we don't add counter++ it will run 0 forever. Very important to add this!
            }
            while (counter < 5);

            // the good of this method is that if in counter is 15 it will write 15 in the console.
            // do starts and check through while if it is false it will writes 15

            Console.Read();
        }
    }
}