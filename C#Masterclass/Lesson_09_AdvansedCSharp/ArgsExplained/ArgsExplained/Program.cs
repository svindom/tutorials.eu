namespace ArgsExplained
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the args array cannot be null. So, it's safe to access the Length property without null checking.
            // so we check the Length of the array if it's zero it means no arguments were provided to the application
            if (args.Length == 0) 
            {
                Console.WriteLine("This is smart app that uses args :), Please provide arguments next time.");
                Console.WriteLine("Pass Help if you want to get more details.");
                //pause the application so it doesn't quite after printing our error message.
                Console.ReadKey();
                //quit the application entirly since we can't proceed futher since, the arguments are empty
                return;
            }

            if (args[0] == "help" || args[0] == "Help")
            {
                //display manual
                Console.WriteLine("******************** Instructions:");
                Console.WriteLine("* use one of the following commands followed by 2 numbers");
                Console.WriteLine("* 'add' : to add 2 numbers");
                Console.WriteLine("* 'sub' : to subtract 2 numbers");
                Console.WriteLine("********************");

                //pause
                Console.ReadKey();
                return;
            }

            //check the length of args
            if (args.Length != 3)
            {
                Console.WriteLine("Invalid arguments, please use the help command for instructions");
                Console.ReadKey();
                //quit the application
                return;
            }

            bool isNum1Parsed = float.TryParse(args[1], out float num1);
            bool isNum2Parsed = float.TryParse(args[2], out float num2);

            if (!isNum1Parsed || !isNum2Parsed)
            {
                Console.WriteLine("Invalid arguments, please use the help command for instructions");
                Console.ReadKey();
                //quit the application
                return;
            }

            // variable to store the results
            float result;
            switch (args[0])
            {
                //case 1 'add' add the two numbers and print the value
                case "add":
                    result = num1 + num2;
                    Console.WriteLine($"The sum of {num1} and {num2} is {result}");
                    break;
                case "sub":
                    result = num1 - num2;
                    Console.WriteLine($"The sub of {num1} and {num2} is {result}");
                    break;
                default:
                    Console.WriteLine("Invalid arguments, please use the help command for instructions");
                    break;

            }


            Console.ReadKey();
        }
    }
}
