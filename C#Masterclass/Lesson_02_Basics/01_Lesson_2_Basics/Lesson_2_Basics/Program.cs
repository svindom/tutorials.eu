namespace Lesson_2_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string and pres enter:");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            Console.Write("Enter a string and pres enter:");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}:",asciiValue);
            Console.ReadKey();
        }
    }
}