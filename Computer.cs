namespace StickGame;

internal class Computer : IPlayer
{
    public string Name { get; } = "Computer";

    public int TakeStick(int stickCount)
    {
        int computerChoice = stickCount % 3 == 0 ? 2 : 1;
        return computerChoice;
    }
}
