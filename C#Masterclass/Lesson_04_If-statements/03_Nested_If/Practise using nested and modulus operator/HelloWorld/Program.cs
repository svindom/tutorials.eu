using System;

// This time you have to complete the NestedCheck method.
// It is supposed to print the right message in the terminal depending on the given value:
// - when the value is divisible by 3. You have to print "Divisible by 3.";
// - when it is not divisible by 3, but divisible by 7 print "Divisible by 7."
// - Otherwise: -when it is an odd number, print "Odd number." OR   - if not, print "Even number."



/*
    About modulus operator "%"

    When we divide 10 by 3 using integer division, we're asking "how many times does 3 fit into 10?"
    3 fits into 10 three times (because 3*3 = 9), and after subtracting 9 from 10, we have 1 left over. 
    This leftover amount is what we call the "remainder."
*/

namespace Coding.Exercise
{
    public class Exercise
    {
        public static void NestedCheck(int number)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("Divisible by 3.");
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("Divisible by 7.");
            }
            else
            {
                if (number % 2 != 0)
                    Console.WriteLine("Odd number.");
                else
                    Console.WriteLine("Even number.");
            }
        }
    }
}