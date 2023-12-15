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
        
        static void Main(string[] args)
        {
            int[] sdudetsGrades = new int[] { 15, 13, 6, 12, 6, 16 };
            double averageResult = GetAverage(sdudetsGrades);

            int[] happiness = { 2, 3, 4, 5, 6 };
            SunIsShining(happiness);

            foreach (int y in happiness) 
            {
                Console.WriteLine(y);
            }

            foreach (int grade in sdudetsGrades)
            {
                Console.WriteLine(" {0} ", grade);
            }

            Console.WriteLine($"The average is: {averageResult}");
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++) 
            {
                sum += gradesArray[i];
            }
            average = Convert.ToDouble(sum) / size;
            return average;
        }

        static void SunIsShining(int[] x)
        {
            for (int i = 0; i < x.Length; i++) 
            {
                x[1] += 2;
            }
        }

    }
}