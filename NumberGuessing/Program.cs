Console.WriteLine("Welcome to the number guessing game");
Console.WriteLine("A number between 1 and 10 will be generated");
Console.WriteLine("If you guess the correct number, you WIN :)");
Console.WriteLine("");

bool isCorrectGuess = false;

Random random = new Random();

int randomNumber = random.Next(1, 11);


while(!isCorrectGuess){
    Console.WriteLine("Please enter your guess: ");
    int guess = Convert.ToInt32(Console.ReadLine());

    if (guess > randomNumber) {
        Console.WriteLine("Your guess is too high");
    }

    if (guess < randomNumber) {
        Console.WriteLine("Your guess is too low");
    }

    if (guess == randomNumber)
    {
        Console.WriteLine($"You guess {guess} is correct");
        isCorrectGuess = true;
    }
}

Console.WriteLine("Congratulations you have won.");


Console.ReadKey();