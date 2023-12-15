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
            // Exercise 1
           for (int counter = 0; counter < 10; counter++) 
            {
                Console.WriteLine(counter + "        counter is lower than 10, so that's why I'm executed");
            }

            Console.WriteLine("        For loop is done, because it has reached number 10");
            Console.WriteLine("--------------------------------------------------------------------------------------------");

            // Exercise 2
           for (int counter2 = 0; counter2 < 50; counter2+=5)
            {
                Console.WriteLine(counter2 + "        counter is lower than 50, so that's why I'm executed");
            }
            Console.WriteLine("        For loop is done, because it has reached number 50");
            Console.WriteLine("--------------------------------------------------------------------------------------------");

            // Exercise 3
            for (int conterOddNumber = 1; conterOddNumber < 20; conterOddNumber+=2)
            {
                Console.WriteLine(conterOddNumber);
            }



            Console.Read();
        }
    }
}