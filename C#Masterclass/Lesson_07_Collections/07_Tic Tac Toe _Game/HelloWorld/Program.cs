using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        // the Playfield
        static char[,] playField =
        {
            {'1', '2', '3' }, // Row 0
            {'4', '5', '6' }, // Row 1
            {'7', '8', '9' }  // Row 2
        };

        static void Main(string[] args)
        {
            int player = 2; // Player 1 starts
            int input = 0;
            bool inputCorrect = true;
           
            // Run code as long as the program runs
            do
            {
                SetField();

                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                do
                {
                    Console.WriteLine("\nPlayer {0}: Choose your field! ", player);
                    input = Convert.ToInt32(Console.ReadLine());
                }
                while (!inputCorrect);
            }
            while (true);
        }

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[0,0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("     |     |     ");
        }

        public static void EnterXorO(int player, int input) 
        {
            char PlayerSign = ' ';

            if (PlayerSign == 1)
            {
                PlayerSign = 'X';
            }
            else if (PlayerSign == 2)
            {
                PlayerSign = 'O';
            }

            switch (input)
            {
                case 1: playField[0, 0] = PlayerSign; break;
                case 2: playField[0, 1] = PlayerSign; break;
                case 3: playField[0, 2] = PlayerSign; break;
                case 4: playField[1, 0] = PlayerSign; break;
                case 5: playField[1, 1] = PlayerSign; break;
                case 6: playField[1, 2] = PlayerSign; break;
                case 7: playField[2, 0] = PlayerSign; break;
                case 8: playField[2, 1] = PlayerSign; break;
                case 9: playField[2, 2] = PlayerSign; break;
            }
        }
    }
}