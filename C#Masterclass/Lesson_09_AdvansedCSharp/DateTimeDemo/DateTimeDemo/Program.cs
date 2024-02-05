using System;
using System.Net.Http.Headers;

namespace DateTimeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2024, 5, 2);
            Console.WriteLine($"Today is {dateTime}");
            Console.WriteLine();

            // Write today on the screen
            Console.WriteLine(DateTime.Today);
            Console.WriteLine();

            // Write current time on the screem
            Console.WriteLine(DateTime.Now);
            Console.WriteLine();

            // Write tomorrow
            Console.WriteLine(GetTomorrow());
            Console.WriteLine();

            // Write a day of a week
            Console.WriteLine(DateTime.Today.DayOfWeek);
            Console.WriteLine();

            // Write a first day of a year
            int year = DateTime.Today.Year;
            Console.WriteLine(GetFirstDayOfYear(year));
            Console.WriteLine();

            // Write days in a month
            int days = DateTime.DaysInMonth(2024, 2);
            Console.WriteLine($"Days in February 2024 are: {days}");
            int days846 = DateTime.DaysInMonth(846, 2);
            Console.WriteLine($"Days in February 846 are: {days846}");
            Console.WriteLine();

            // Write current tome
            DateTime now = DateTime.Now;
            Console.WriteLine($"Minute: {now.Minute}");
            Console.WriteLine();
            Console.WriteLine($"The current time is: {now.Hour}:{now.Minute}:{now.Second}");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine();

            bool isCorrect = false;
            while (!isCorrect)
            {
                Console.WriteLine("Write a date in this format: yyyy-mm-dd");
                string userInput = Console.ReadLine();
                DateTime date = new DateTime();
                if (DateTime.TryParse(userInput, out date))
                {
                    Console.WriteLine(date);
                    TimeSpan daysPassed = now.Subtract(date);
                    Console.WriteLine($"Days passed since: {daysPassed.Days}");
                    isCorrect = true;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine();
                    isCorrect = false;
                }
            }
            



            Console.ReadKey();
        }

        static DateTime GetTomorrow()
        {
            // to write a tommorow we use this approach
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear (int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}