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
            // Declare 2D Array
            string[,] matrix;

            // Declare 3D Array
            string[,,] threeD;

            //  2D Array
            int[,] arrayTwoD = new int[,]
            {
                { 1, 2, 3, },
                { 4, 5, 6, },
                { 7, 8, 9, },
            };

            arrayTwoD[1, 1] = 10; // here is how we can change the value

            Console.WriteLine($"Central value is {arrayTwoD[1, 1]}"); // row number 1 is 0. Row 2 is 1 so that's why 5 (now it is 10 because we changed it) is 1, because 4 is 0
            Console.WriteLine("---------------------------------------------------------------------------------------");

            int dimensions = arrayTwoD.Rank;

            Console.WriteLine($"The dimensions of arrayTwoD is: {dimensions}");
            Console.WriteLine("---------------------------------------------------------------------------------------");

            // The shorthand of writing Dimensional Array
            int[,] arrayTwoDShorthand = { { 1, 2 }, { 3, 4 } };

            Console.WriteLine($"The shorthand of dimensional Array, and the value is: {arrayTwoDShorthand[1,0]}");
            Console.WriteLine("---------------------------------------------------------------------------------------");

            //  3D Array
            string[,,] arrayThreeD = new string[,,]   
            // We must have the same ammount of rows and value inside a row in the boxes
            {
                {
                    {"000", "001"},
                    {"010", "011"},
                    {"Hi there", "What's up"}
                },
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"Another one", "Last entry"}
                }
            };
            Console.WriteLine($"The value is ->   {arrayThreeD[0, 2, 0]}");
        }
    }
}