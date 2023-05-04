namespace StickGame;

internal class Game
{
    private readonly IPlayer player1;
    private readonly IPlayer player2;
    public const int INITAL_STICK_COUNT = 21;
    private static IPlayer? currentPlayer;

    public int Sticks { get; private set; }

    public Game(IPlayer player1, IPlayer player2)
    {
        Sticks = INITAL_STICK_COUNT;
        this.player1 = player1;
        this.player2 = player2;
        currentPlayer = player1;
    }

    public int PlayerTakeStick()
    {
        int takenStickCount = currentPlayer.TakeStick(Sticks);

        Sticks -= takenStickCount;

        currentPlayer = currentPlayer == player1 ? player2 : player1;

        return takenStickCount;

    }
    public bool IsCurrentPlayerComputer()
    {
        return currentPlayer is Computer;

    }

    public bool IsGameOver()
    {
        return Sticks <= 1;
    }

    public IPlayer? GetLoser()
    {
        if (Sticks == 1)
        {
            return currentPlayer == player1 ? player1 : player2;
        }
        return player2;
    }
}