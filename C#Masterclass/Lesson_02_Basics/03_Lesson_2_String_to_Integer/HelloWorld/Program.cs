using System;

namespace HelloWorld // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int resultInt = num1+ num2;
            string result = myString+ mySecondString;   

            Console.WriteLine($"This is a parsing result of int : {resultInt} and this is a string result : {result}");

        }
    }
}