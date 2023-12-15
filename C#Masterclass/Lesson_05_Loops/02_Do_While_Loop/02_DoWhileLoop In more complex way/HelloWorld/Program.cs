using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    class Program
    {
      static void Main(string[] args) 
        {
            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please, enter the name of a friend");
                string nameOfAFriend = Console.ReadLine();
                int currentLength = nameOfAFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfAFriend;

            }
            while (lengthOfText < 20);
            Console.WriteLine("Thanks, it was enough! " + wholeText);


            Console.Read();
        }
    }
}