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
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;

            try // type "try" and double tap on the "tab button"
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero!");
            }


            try  // type "try" and double tap on the "tab button"
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {

                Console.WriteLine("Rormat exception, please enter the correct type next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for an Int.32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullexception, the value was empty (null)");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }



            Console.ReadKey();
        }

    }
}