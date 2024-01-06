string[] gameElements = new string[] { "rock", "paper", "scissors" };

Game game = new Game();
bool isPlayingGame = game.isPlaying;


while (isPlayingGame)
{
    game.GreetingPlayer();
    string playerMove = game.GetPlayerMove(gameElements);
    string computerMove = game.GetComputerMove(gameElements);
    int gameRound = game.rounds;

    Console.WriteLine($"Your choice: {playerMove}");
    Console.WriteLine($"Your choice: {computerMove}");

    while (gameRound > 0)
    {
        Console.WriteLine($"---------------------------------Round{gameRound}---------------------------------");
        game.PlayRound(playerMove, computerMove, gameElements, gameRound);
        gameRound--;
    }
    game.DetermineWinner(game.playerTotalWins, game.computerTotalWins);

    game.GetAnawerToPlayAgain(isPlayingGame);
}


Console.ReadKey();

class Game
{
    public int rounds = 3;
    public string[] gameElements = new string[3];
    public int playerTotalWins = 0;
    public int computerTotalWins = 0;
    public bool isPlaying = true;



    public void GreetingPlayer()
    {
        Console.WriteLine("Hi Player!");
        Console.WriteLine("Let's play the \'Rock paper scissors\' game!");
        Console.WriteLine($"You have {rounds} rounds to win a computer");
        Console.WriteLine();

    }
    public string GetPlayerMove(string[] moves)
    {
        GetGameIntro();

        string userInput = Console.ReadLine().ToUpper();
        while (!IsValidMove(userInput, moves))
        {
            Console.WriteLine($"Your input \'{userInput}\' is not valid");
            GetGameIntro();
        }
        return userInput;
    }
    public bool IsValidMove(string move, string[] validMoves)
    {
        foreach (string validMove in validMoves)
        {
            if (move == validMove)
            {
                return true;
            }
        }
        return false;
    }
    public void GetGameIntro()
    {
        Console.WriteLine("Please chose your element:");
        Console.WriteLine($"Enter [R] to choose {gameElements[0]}");
        Console.WriteLine($"Enter [R] to choose {gameElements[1]}");
        Console.WriteLine($"Enter [R] to choose {gameElements[2]}");
    }

    public string GetComputerMove(string[] moves)
    {
        Random random = new Random();
        return moves[random.Next(0, moves.Length)];
    }

    public void PlayRound(string playerMove, string computerMove, string[] moves, int rounds)
    {

        if (playerMove == computerMove)
        {
            Console.WriteLine("It's a tie");
        }
        else if ((playerMove == moves[0] && computerMove == moves[2]) ||
                 (playerMove == moves[1] && computerMove == moves[0]) ||
                 (playerMove == moves[2] && computerMove == moves[1]))
        {
            Console.WriteLine($"You win a round {rounds}");
            rounds--;
            playerTotalWins++;
        }
        else
        {
            Console.WriteLine($"Computer win a round {rounds}");
            rounds--;
            computerTotalWins++;
        }
    }

    public void DetermineWinner(int playerTotalWins, int computerTotolWins)
    {
        if (playerTotalWins > computerTotolWins)
        {
            Console.WriteLine("Congratulations! You win the Game! You should be proud of yourself");
        }
        else
        {
            Console.WriteLine("Sorry, you lose. Better luck next time!");
        }
    }

    public void GetAnawerToPlayAgain(bool isPlayingGame)
    {
        string userAnswer = Console.ReadLine().ToUpper();
        while (userAnswer == "Y" || userAnswer == "N")
        {
            Console.WriteLine("Do you want repeat the game?");
            Console.WriteLine("Press [Y] if yes\nPress [N] if no");

            if (userAnswer == "Y")
            {
                isPlaying = true;
            }
            else if (userAnswer == "N")
            {
                isPlaying = false;

            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        isPlaying = true;
    }

}
