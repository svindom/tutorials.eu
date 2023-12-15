using System;

namespace HelloWorld // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 25;                       //0 to 255
            Console.WriteLine(myByte);

            sbyte mySByte = -15;                    //-128 to 127
            Console.WriteLine(mySByte);

            int myInt = -12318925;                  //-2,147,483,648 to 2,147,483,647 
            Console.WriteLine(myInt);

            uint myUInt = 123091;                   //0 to 4294967295
            Console.WriteLine(myUInt);

            short myShort = 6535;                   //-32,768 to 32,767
            Console.WriteLine(myShort);

            float myFloat = -31.1289f;              //-3.402823e38 to 3.402823e38
            Console.WriteLine(myFloat);

            double myDouble = -12.1231250;          //-1.79769313486232e308 to 1.79769313486232e308
            Console.WriteLine(myDouble);

            char myChar = 'A';                      //Unicode symbols used in text
            Console.WriteLine(myChar);

            bool myBool = true;                     //True or false
            Console.WriteLine(myBool);

            string myText = "I control text";       // A sequence of characters
            Console.WriteLine(myText);

            string numText = "15";
            Console.WriteLine(numText);

            int myNumFromText = int.Parse(numText);
            Console.WriteLine(myNumFromText);
            Console.ReadLine();
        }

    }
}