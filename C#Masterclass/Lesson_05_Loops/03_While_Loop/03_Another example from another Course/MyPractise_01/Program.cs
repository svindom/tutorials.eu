using System;
namespace MyPractise_01

{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++) 
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("-------------------------------------------------------------");

            int j = 0;
            while (j <= 10)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }
            Console.WriteLine("-------------------------------------------------------------");

            while (true)
            {
                Console.Write("Type youe name: ");
                string input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;

                Console.WriteLine("@Echo: " + input);
            }

        }
    }
}