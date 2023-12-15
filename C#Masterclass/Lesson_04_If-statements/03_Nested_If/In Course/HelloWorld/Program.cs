using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter youe user name:");
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            userName = Console.ReadLine();

            if (isRegistered)
            {
                Console.WriteLine("Hi there, registered user");
                if (userName != "")
                {
                    Console.WriteLine("Hi there, " + userName);
                    // .Equals = it checks whatever is inside of "userName" and compares with that string which is "Admim" in our case.
                    // It uses only with strings. With int use "==". Example --> if(myInt == myInt2)
                    if (userName.Equals("admin") || userName.Equals("Admin")) 
                    {
                        Console.WriteLine("Hi there, Admin");
                    }
               
                } 
                

            }
            // Another, might be a better way to do the same action

            /*
            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, registered user");
                Console.WriteLine("Hi there, " + userName);
                Console.WriteLine("Hi there, Admin");
            }
            */

            if(isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in");
            }


        }
    }
}