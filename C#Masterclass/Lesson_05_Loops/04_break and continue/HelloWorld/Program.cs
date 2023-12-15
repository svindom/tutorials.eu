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
            // break stopes the loop, in our case on 3
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
                if (counter == 3)
                {
                    Console.WriteLine("At 3 we stop!");
                    break;
                }
            }

            Console.WriteLine("--------------------------------------------------------------------------");


            // continue doesn't stop but only executes and after then finishes all conditions
            for (int counter2 = 0; counter2 < 10; counter2++)
            {
                if (counter2 == 3)
                {
                    Console.WriteLine("We skip the 3!");
                    continue;
                }
                Console.WriteLine(counter2);
            }
            Console.WriteLine("--------------------------------------------------------------------------");

            for (int counter3 = 0; counter3 < 10; counter3++)
            {
                if (counter3 %2 == 0)
                {
                    Console.WriteLine("it is an odd number");
                    continue;
                }
                Console.WriteLine(counter3);
            }

            Console.Read();
        }
    }
}