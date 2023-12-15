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
            // condition ? first_expression : second_expression;
            // condition has to be either true or false
            // The conditional operator is right - associative.
            // The expression a ? b : c ? d : e
            // is evaluated as a ? b : (c ? d : e),
            // not as (a? b : c) ? d: e.
            // The conditional operator cannot be overloaded.

            // Common method:
            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0)
            {
                stateOfMatter = "solid";
            }
            else
            {
                stateOfMatter = "liquid";
            }
            Console.WriteLine($"State of matter is {stateOfMatter}");

            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            // Short method:
            temperature += 30;

            stateOfMatter = temperature < 0 ? "solid" : "liquid";
            Console.WriteLine($"State of matter is {stateOfMatter}");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            // challenge - add the gas state of matter to the option
            temperature += 100;
            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

            Console.WriteLine($"State of matter is {stateOfMatter}");
        }
    }
}