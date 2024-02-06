namespace NullablesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<Int32> @int;
            int? num1 = null;
            int? num2 = 1337;

            double? num3 = new Double?();
            double? num4 = 3.128585;

            bool? boolval = new bool?();

            Console.WriteLine($"Our nullable numbers are: {num1}, {num2}, {num3}, {num4}");
            Console.WriteLine($"The nullable boolean value is {boolval}");

            Console.WriteLine();

            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("A user is a male");
            }
            else if (isMale == false) 
            {
                Console.WriteLine("A user is a female");
            }
            else
            {
                Console.WriteLine("No gender chosen");
            }

            Console.WriteLine();

            double? num6 = 13.1;
            double? num7 = null;
            double? num8;

            if (num6 == null)
            {
                num8 = 0.0;
            }
            else 
            {
                num8 = (double)num6;
            }
            Console.WriteLine($"Value of num is: {num8}");

            Console.ReadKey();
        }
    }
}
