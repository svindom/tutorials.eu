namespace StructsDemo
{
    struct Game
    {
        public string name;
        public string developer;
        public float rating;
        public string releaseDate;

        public void GetDisplay()
        {
            Console.WriteLine($"Game name is: {name}");
            Console.WriteLine($"The game was developed by {developer}");
            Console.WriteLine($"{name} has rating of {rating}");
            Console.WriteLine($"It will be released on {releaseDate}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Game game1;
            game1.name = "Annika";
            game1.developer = "Svindom Games";
            game1.rating = 4.8f;
            game1.releaseDate = "29.04.2024"; 

            game1.GetDisplay();

            Console.ReadKey();
        }

    }
}