using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine (Add(Add(1, 2), Add(3,4)));
            Console.WriteLine(Add(15, 31));
            Console.WriteLine(Multiply(3,5));
            Console.WriteLine(Devide(14, 9));
            Console.Read();
        }
        public static int Add (int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num3, int num4)
        {
            return num3 * num4; 
        }

        public static double Devide(double num5, double num6)
        {
            return num5 / num6; 
        }

    }
}