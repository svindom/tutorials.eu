using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{

    internal class Program
    {
      static void Main(string[] args) 
        {
            // The First way of initializing an array
            // declare and initialize array grades
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.WriteLine($"grades at index 0 : {grades[0]}");


            // Assign value to array grades at index 0

            bool isValidInput = false;
            while(!isValidInput)
            {
                Console.WriteLine("Enter any integer to change a number at 0 index to something you want");
                string inputTwo = Console.ReadLine();
                int parsedGrades;
                if (int.TryParse(inputTwo, out parsedGrades))
                {
                    grades[0] = parsedGrades;
                    Console.WriteLine($"grades at index 0 : {grades[0]}");
                    isValidInput = true;   // Exit the loop since we have a valid input
                }
                else
                {
                    Console.WriteLine("Please enter a number, not a symbol");
                }

            }

            Console.WriteLine("--------------------------------------------------------------------------------------------");

            // The Second way of initializing an array
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 5 };

            // The Third way of initializing an array
            int[] gradesOfMathStudentsB = new int[] { 20, 13, 12, 11, 9, 3 };

            Console.WriteLine($"Length of gradesOfMathStudentsA: {gradesOfMathStudentsA.Length}"); //.Length a metod that checks how many "something" are in Array.




        }
    }
}