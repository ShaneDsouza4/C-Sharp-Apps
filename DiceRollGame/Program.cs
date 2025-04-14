var random = new Random();
int diceRoll = random.Next(1, 7);
int correctGuess = 0;
//int userInput;
Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");

int triesToRun = 3;


for (int i=1; i<=triesToRun; i++)
{
    Console.WriteLine("Enter Number: ");
    string userInput = Console.ReadLine();
    bool isParsingSuccesfull = int.TryParse(userInput, out int number);
    if (isParsingSuccesfull)
    {
        if(number == diceRoll)
        {
            correctGuess = number;
            break;
        }
    }
    else
    {
        Console.WriteLine("Incorrect Input. Please try again.");
    }
}

if (correctGuess == diceRoll)
{
    Console.WriteLine("You win");
}
else
{
    Console.WriteLine("You loose");
}

Console.ReadKey();