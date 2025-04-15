using DiceRollGame.UserCommunication;

namespace DiceRollGame.Game
{
    class GuessingGame
    {
        private readonly Dice _dice;
        private const int InitialTries = 3;

        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }

        public GameResult Play()
        {
            var diceRollResult = _dice.Roll();
            Console.WriteLine($"Dice Rolled. Guess what number it shows in {InitialTries} tries.");

            var triesLieft = InitialTries;
            while (triesLieft > 0)
            {
                var guess = ConsoleReader.ReadInteger("Enter a number");
                if (guess == diceRollResult)
                {
                    return GameResult.Victory;
                }
                Console.WriteLine("Wrong Number");
                --triesLieft;
            }
            return GameResult.Loss;
        }

        public void PrintResult(GameResult gameResult)
        {
            string message = gameResult == GameResult.Victory
                ? "You Win :D"
                : "You Loose :(";

            Console.WriteLine(message);
        }
    }
}
