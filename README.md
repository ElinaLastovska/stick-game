# stick-game
A simple console-based Stick Game implemented in C#.

Description
This game is played between two players, where the players take turns to pick up sticks from a pile of sticks. The player who picks up the last stick loses the game.

Usage
To run the game, compile the code and run the StickGame.exe file. When the game starts, you will be prompted to choose whether to play with another player or with the computer. To make a choice, enter p for playing with a human player, or c for playing with the computer.

If you choose to play with another player, you will be prompted to enter the names of the players. Then, each player will be prompted to take 1 or 2 sticks from the pile. The player who takes the last stick loses the game.

If you choose to play with the computer, you will be prompted to choose who goes first. After that, you will play against the computer. The computer will make moves based on a simple algorithm that removes 1 or 2 sticks from the pile.

Code
Program.cs
The Program class is the entry point of the program. It contains the Main method that starts the game.

Game.cs
The Game class represents a game of stick. It contains information about the state of the game, such as the number of sticks remaining, and the players. It also has methods for playing the game, such as PlayerTakeStick, which removes sticks from the pile, and IsGameOver, which checks if the game is over.

Human.cs
The Human class represents a human player. It implements the IPlayer interface and has a method for taking sticks from the pile.

Computer.cs
The Computer class represents a computer player. It implements the IPlayer interface and has a simple algorithm for taking sticks from the pile.

IPlayer.cs
The IPlayer interface defines the methods and properties that a player in the game should implement.

Sample Code
csharp
Copy code
Game game = new Game(new Human("player1"), new Human("player2"));

// Start playing the game
PlayAndShowRezult(game);

public static void PlayAndShowRezult(Game game)
{
    Play(game);
    IPlayer loser = game.GetLoser();

    Console.WriteLine($"{loser.Name} lost.");
}
Contributions
Contributions are welcome! If you want to contribute to this project, please feel free to submit a pull request.
