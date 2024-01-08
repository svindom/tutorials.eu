
class Program
{
    static void Main(string[] args)
    {
        string[] gameObjects = new string[] { "Rock", "Paper", "Scissors"};
        string playerMove = "";
        string computerMove;

        bool playAgain = true;


        Random random = new Random();

        do
        {
            int playerScore = 0;
            int computerScore = 0;
            int gameAttempts = 0;

            Console.WriteLine();
            Console.WriteLine("Hi Player!\nLet's play the game \'Rock, Paper, Scissors\'");

            while ( gameAttempts < 3)
            {
                bool isValidPlayerInput = false;

                computerMove = gameObjects[random.Next(0, gameObjects.Length)];

                while (!isValidPlayerInput)
                {
                    Console.WriteLine();
                    Console.WriteLine($"-----------------------------Attempt{gameAttempts + 1}-----------------------------");
                    Console.WriteLine("Press [R] key to choose \'Rock\'");
                    Console.WriteLine("Press [P] key to choose \'Paper\'");
                    Console.WriteLine("Press [S] key to choose \'Scissors\'");

                    playerMove = Console.ReadLine().ToUpper();

                    if (playerMove == "R" || playerMove == "P" || playerMove == "S")
                    {
                        isValidPlayerInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                        isValidPlayerInput = false;
                    }
                }

                switch (playerMove)
                {
                    case "R":
                        if (computerMove == gameObjects[0])
                        {
                            Console.WriteLine($"Computer has '{gameObjects[0]}'. It's tie!");
                            Console.WriteLine($"Your score: {playerScore}, computer score: {computerScore}");
                            Console.WriteLine();
                        }
                        else if (computerMove == gameObjects[1])
                        {
                            computerScore++;
                            gameAttempts++;
                            Console.WriteLine($"Computer has \'{gameObjects[1]}\'. He wins this turn.");
                            Console.WriteLine($"Your score: {playerScore}, computer score: {computerScore}");
                            Console.WriteLine();
                        }
                        else if (computerMove == gameObjects[2])
                        {
                            playerScore++;
                            gameAttempts++;
                            Console.WriteLine($"Computer has \'{gameObjects[2]}\'. Great! You win this turn.");
                            Console.WriteLine($"Your score: {playerScore}, computer score: {computerScore}");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Something went wrong. I will check it");
                        }
                        break;
                    case "P":
                        if (computerMove == gameObjects[1])
                        {
                            Console.WriteLine($"Computer has '{gameObjects[1]}'. It's tie!");
                            Console.WriteLine($"Your score: {playerScore}, computer score: {computerScore}");
                            Console.WriteLine();
                        }
                        else if (computerMove == gameObjects[2])
                        {
                            computerScore++;
                            gameAttempts++;
                            Console.WriteLine($"Computer has \'{gameObjects[2]}\'. He wins this turn.");
                            Console.WriteLine($"Your score: {playerScore}, computer score: {computerScore}");
                            Console.WriteLine();
                        }
                        else if (computerMove == gameObjects[0])
                        {
                            playerScore++;
                            gameAttempts++;
                            Console.WriteLine($"Computer has \'{gameObjects[0]}\'. Great! You win this turn.");
                            Console.WriteLine($"Your score: {playerScore}, computer score: {computerScore}");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Something went wrong. I will check it");
                        }
                        break;
                    case "S":
                        if (computerMove == gameObjects[2])
                        {
                            Console.WriteLine($"Computer has '{gameObjects[2]}'. It's tie!");
                            Console.WriteLine($"Your score: {playerScore}, computer score: {computerScore}");
                            Console.WriteLine();
                        }
                        else if (computerMove == gameObjects[0])
                        {
                            computerScore++;
                            gameAttempts++;
                            Console.WriteLine($"Computer has \'{gameObjects[0]}\'. He wins this turn.");
                            Console.WriteLine($"Your score: {playerScore}, computer score: {computerScore}");
                            Console.WriteLine();
                        }
                        else if (computerMove == gameObjects[1])
                        {
                            playerScore++;
                            gameAttempts++;
                            Console.WriteLine($"Computer has \'{gameObjects[1]}\'. Great! You win this turn.");
                            Console.WriteLine($"Your score: {playerScore}, computer score: {computerScore}");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Something went wrong. I will check it");
                        }
                        break;
                }

                if (playerScore == 2 || computerScore == 2)
                {
                    break; // Break out of the loop if ether player reach 2 points to the score or the computer does
                }
            }

            if (playerScore > computerScore)
            {
                Console.WriteLine("Congratulation! You win the Game!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("What a pity! Computer wins! Good luck next time!");
                Console.WriteLine();
            }

            Console.WriteLine("Do you want replay? [Y or N]");
            string userAnswer = Console.ReadLine().ToUpper();
            while (userAnswer != "Y" && userAnswer != "N" )
            {
                Console.WriteLine("Invalid input. Please answer with 'Y' for Yes or 'N' for No.");
                userAnswer = Console.ReadLine().ToUpper();
            }
            playAgain = userAnswer == "Y";


        }
        while (playAgain);

       

        Console.ReadKey();

    }
}


