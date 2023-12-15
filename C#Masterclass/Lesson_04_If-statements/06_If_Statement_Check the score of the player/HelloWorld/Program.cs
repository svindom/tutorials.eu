using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    class Program
    {
        static int highscore = 300;
        static string highscorePlayer = "Alex";
        static void Main(string[] args)
        {
            CheckHighScore(250, "Maria");
            CheckHighScore(315, "Michael");
            CheckHighScore(350, "July");

            Console.Read();
        }    
        public static void CheckHighScore(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);
            }
            else 
            {
                Console.WriteLine("The old highscore could not be broken. It is still " + highscore + " and held by " + highscorePlayer);
            }

        }
    }
}