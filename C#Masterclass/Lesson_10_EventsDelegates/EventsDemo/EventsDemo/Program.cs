namespace EventsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AudioSystem audioSystem = new AudioSystem();
            RenderingEngine renderingEngine = new RenderingEngine();

            Player player1 = new Player("Aragorn");
            Player player2 = new Player("Enom");


            audioSystem.StartGame();
            renderingEngine.StartGame();

            player1.StartGame();
            player2.StartGame();

            Console.WriteLine("Game is running... Press ane key to end the game.");

            //pause
            Console.Read();

            renderingEngine.GameOver();
            audioSystem.GameOver();

            player1.GameOver();
            player2.GameOver();
            



            Console.ReadKey();
        }
    }
}

class Player
{
    public string PlayerName { get; set; }

    public Player (string playerName)
    {
        this.PlayerName = playerName;
    }

    public void StartGame()
    {
        Console.WriteLine($"Spawning Player with ID : {PlayerName}");
    }

    public void GameOver()
    {
        Console.WriteLine($"Removing Player with ID : {PlayerName}");
    }
}

public class RenderingEngine
{
    public RenderingEngine()
    {
        GameEventManager.OnGAmeOver += StartGame;
        GameEventManager.OnGAmeOver += GameOver;
    }

    private void StartGame()
    {
        Console.WriteLine("Rendering Engine Started");
        Console.WriteLine("Drawing Visuals...");
    }

    private void GameOver()
    {
        Console.WriteLine("Rendering Engin Stopped");
    }
}

public class AudioSystem
{
    public AudioSystem()
    {
        GameEventManager.OnGAmeOver += StartGame;
        GameEventManager.OnGAmeOver += GameOver;
    }

    private void StartGame()
    {
        Console.WriteLine("Audio System Started");
        Console.WriteLine("Playing Audio...");
    }

    private void GameOver()
    {
        Console.WriteLine("Audio Systemn Stopped");
    }
}

class GameEventManager
{
    // anew delegate type called GameEvent
    public delegate void GameEvent();

    // create two delegates variables called OnGameStart an OnGameOver
    public static GameEvent OnGameStart, OnGAmeOver; 
}
