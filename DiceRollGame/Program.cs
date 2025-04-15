using DiceRollGame.Game;

var random = new Random(12);
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);

GameResult gameResult = guessingGame.Play();
guessingGame.PrintResult(gameResult);


Console.ReadKey();
