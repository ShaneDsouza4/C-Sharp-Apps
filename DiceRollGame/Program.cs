

var game = new Game();
var diceRollNumber = game._diceRolledNumber;

Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");

var playerGuess = 0;
var player = new Player();
int chances = player.PlayerChances;

for(int i=1; i<=chances; i++)
{
    playerGuess = player.TakePlayerInput();
    if(playerGuess == 0)
    {
        Console.WriteLine("Incorrect Input. Please try again."
            );
        chances++;
    }

    if(playerGuess == diceRollNumber)
    {
        break;
    }
    else
    {
        Console.WriteLine("Wrong Number.");
    }
}

if(playerGuess == diceRollNumber)
{
    Console.WriteLine("You Win");
}
else
{
    Console.WriteLine("You loose :(");
}


Console.ReadKey();

class Player
{
    public int userGuess;
    public int PlayerChances = 3;

    public int TakePlayerInput()
    {
        Console.WriteLine("Enter Number");
        string userInput = Console.ReadLine();

        bool isParsingSuccesfull = int.TryParse(userInput, out int number);
        if (isParsingSuccesfull)
        {
            return number;
        }
        return 0;
    }

}

class Game
{
    public int _diceRolledNumber;

    public Game()
    {
        _diceRolledNumber = RollDice();
    }

    private int RollDice()
    {
        var random = new Random();
        return random.Next(1, 7);
    }
}


