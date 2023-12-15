using System;

namespace HelloWorld // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define new variables
            int age = 31;
            string name = "Alex";

            // 1. string concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is" + name + " , I am " + age + " years old");

            // 2. String formatting.
            // string formatting uses index
            Console.WriteLine("String formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old.", name, age);

            // 3. String interpolation.
            // Srting interpolation uses $ at the start which will allow us to write variables like this {variableName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is Alex {name} , I am {age} years old.");

            // 4. Verbatim String
            Console.WriteLine(@"www.udemy.com/course/complete-csharp-masterclass/learn/lecture/27278808#overview");

        }
    }
}