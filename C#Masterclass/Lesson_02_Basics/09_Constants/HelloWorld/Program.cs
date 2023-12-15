using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld

    // Constans are immutable values that are known at compile time and do not change for the life of the program
{
    class Program
    {
        //Constans as fields
        const double PI = 3.14159265359;
        const int weeks = 52, month = 12;
        const string myBirthday = "the 17th of July, namely today! :)";

        static void Main(string[] args)
        {
            Console.WriteLine(myBirthday);
        }

    }
}