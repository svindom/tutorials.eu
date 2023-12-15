using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethinSpecific("I am argument and am called from a method");
            Console.Read();
        }
        // acces midifier (static) return type method name (parameter1, parameter2)
        public static void WriteSomething ()
        {
            Console.WriteLine("I am called from the method");
        }

        public static void WriteSomethinSpecific (string myText)
        {
            Console.WriteLine(myText);
        }

    }
}