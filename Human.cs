namespace StickGame;

internal class Human : IPlayer
{

    public string Name { get; }

    public Human(string name)
    {
        Name = name;
    }

    public int TakeStick(int stickCount)
    {
        Console.WriteLine("How many sticks will you take: (1-2)?");
        int userChoice;

        while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 2)
        {
            Console.WriteLine("Invalid choice! You can only remove 1 or 2 sticks. Try again");
        }

        return userChoice;
    }
}