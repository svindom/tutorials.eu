using System;


namespace HelloWorld
{
    public class Program
    {
        static string userName;
        static string password;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }
        public static void  Register()
        {
            Console.WriteLine("Please enter your user name");
            userName = Console.ReadLine();
            Console.WriteLine("Please enter your user password");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
            Console.WriteLine("---------------------------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your user name");
            if (userName == Console.ReadLine())
            {
                Console.WriteLine("Please enter your user password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Loggin failed, wrong password. Please, restart the programm");
                }
            }
            else
            {
                Console.WriteLine("Loggin failed, wrong username. Please, restart the programm");
            }
        }
    }
}