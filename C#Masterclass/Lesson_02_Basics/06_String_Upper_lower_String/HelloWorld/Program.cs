using System;

namespace HelloWorld // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName;
            Console.Write("Please enter your name: ");
            myName = Console.ReadLine();
            string myNameUpperCase = String.Format("Uper case : {0}", myName.ToUpper());
            string myNameLowerCase = String.Format("Lover case : {0}", myName.ToLower());
            string myNameTrimmed = String.Format("Trimmed value : {0}", myName.Trim());
            string myNameSubstring = String.Format("Substring value : {0}", myName.Substring(0, 5));

            Console.WriteLine(myNameUpperCase);
            Console.WriteLine(myNameLowerCase);
            Console.WriteLine(myNameTrimmed);
            Console.WriteLine(myNameSubstring);

            Console.ReadKey();  
        }
    }
}