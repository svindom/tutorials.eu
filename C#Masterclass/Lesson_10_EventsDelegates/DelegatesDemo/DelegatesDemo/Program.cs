namespace DelegatesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Alex"};

            Console.WriteLine("-----------before-----------");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.RemoveAll(Filter);

            Console.WriteLine("-----------after-----------");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }

        // method that takes a string
        static bool Filter (string s)
        {
            // Return whether the string s contains the letter 'i'
            // the Contains method will return a bool which we will return as well
            return s.Contains("i");
        }


    }
}
