namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is implicit conversion
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;
            string myFloatToString = myFloat.ToString();




            double myDouble = 13.37;
            int myInt;
            // This is explicit conversion
            // cast double to integer
            myInt = (int)myDouble;

            // typeConversion
            // to convert int to string
            string myString = myDouble.ToString(); // <--- it wil convert 13.37 but as a string "13.37"

            bool sunIsShining = true;
            string myBoolToString = sunIsShining.ToString();

            Console.WriteLine(myFloatToString);
            Console.Read();
        }
    }
}