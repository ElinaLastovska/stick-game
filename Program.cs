namespace StickGame;

class Program
{
    static void Main()
    {
        Console.WriteLine($"Welcome to the {Game.INITAL_STICK_COUNT} sticks game!");

        string answer = GetPlayerChoice();
        switch (answer)
        {
            case "p":
                PlayWithHuman();
                break;
            case "c":
                PlayWithComputer();
                break;
        }
    }

    static string GetPlayerChoice()
    {
        string userInput;
        do
        {
            Console.WriteLine("Do you want to play with computer or other player (c/p):?");
            userInput = Console.ReadLine().ToLower();

            if (userInput == "p" || userInput == "c")
                return userInput;

            Console.WriteLine("Invalid input. Only 'p' or 'c' are allowed. Try again.");

        } while (userInput != "p" || userInput != "c");

        return userInput;
    }

    public static void PlayWithHuman()
    {
        Game game = new Game(new Human("player1"), new Human("player2"));

        PlayAndShowRezult(game);
    }

    public static string GetPlayersChoiceOnFirstMove()
    {
        Console.Write($"Do you want to start {Game.INITAL_STICK_COUNT} stick game (y/n): ");
        string userInput = Console.ReadLine().ToLower();

        if (userInput != "y" && userInput != "n")
        {
            Console.WriteLine("Invalid input. Only 'y' or 'n' are allowed.");
        }

        return userInput;
    }

    public static void PlayWithComputer()
    {
        string firstMove = GetPlayersChoiceOnFirstMove();

        var player1 = new Human("You");
        var player2 = new Computer();
        var game = firstMove == "y" ? new Game(player1, player2) : new Game(player2, player1);

        PlayAndShowRezult(game);
    }

    public static void PlayAndShowRezult(Game game)
    {
        Play(game);
        IPlayer loser = game.GetLoser();

        Console.WriteLine($"{loser.Name} lost.");
    }

    public static void Play(Game game)
    {
        while (!game.IsGameOver())
        {
            Console.WriteLine($"{game.Sticks} sticks left");

            bool isComputer = game.IsCurrentPlayerComputer();
            int takenStickCount = game.PlayerTakeStick();

            if (isComputer)
                Console.WriteLine($"Computer removes {takenStickCount} sticks.");
        }
    }
}

