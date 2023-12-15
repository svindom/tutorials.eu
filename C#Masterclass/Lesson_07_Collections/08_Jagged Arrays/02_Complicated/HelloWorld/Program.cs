using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        // Create a jagged array, which contains 3 "friends array", in which two family members should be stored
        // Introduce family members from differentfamilies to each other via console (three introductions)

        static void Main(string[] args)
        {
            string[] joesFamily = new string[] { "Martha", "Nockole" };

            string[][] friendsAndFamily = new string[][]
            {
                new string[]{"Alex", "Kristine" },
                new string[]{"Frank", "Claudia" },
                new string[]{"Jessy", "Monica"},
                joesFamily
            };

            Console.WriteLine($"Hi {friendsAndFamily[0][0]}, I would like to introduce {friendsAndFamily[1][0]} to you.");
            Console.WriteLine($"Hi {friendsAndFamily[0][1]}, I would like to introduce {friendsAndFamily[2][0]} to you.");
            Console.WriteLine($"Hi {friendsAndFamily[0][1]}, I would like to introduce {friendsAndFamily[2][1]} to you.");
        }
    }
}