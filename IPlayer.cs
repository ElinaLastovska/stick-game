namespace StickGame;

interface IPlayer
{
    string Name { get; }

    int TakeStick(int stickCount);
}