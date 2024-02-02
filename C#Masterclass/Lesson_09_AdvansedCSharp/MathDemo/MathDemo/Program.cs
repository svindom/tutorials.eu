namespace MathDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numToManip = 16.4f;

            Console.WriteLine($"Ceiling: {Math.Ceiling(numToManip)}");
            Console.WriteLine();
            Console.WriteLine($"Floor: {Math.Floor(numToManip)}");

            // Power of num
            int num1 = 6;
            int num2 = 7;
            double resultPowerOf = Math.Pow(num1, num2);

            Console.WriteLine($"{num1} to the power of {num2} is {resultPowerOf}");
            Console.WriteLine();

            // Calculate PI
            double numberPI = Math.PI;
            Console.WriteLine($"The number PI is: {numberPI}");
            Console.WriteLine();

            // Clculate the squre root
            int num3 = 25;
            double squareRootNum = Math.Sqrt(num3);
            Console.WriteLine($"The square root of {num3} is: {squareRootNum}");
            Console.WriteLine();

            // Calulate cos
            int num4 = 1;
            double cosNum = Math.Cos(num4);
            Console.WriteLine($"The cosof {num3} is: {cosNum}");



            Console.ReadKey();
        }
    }
}