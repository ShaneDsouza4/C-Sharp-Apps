namespace DiceRollGame.Game
{
    public class Dice
    {
        private readonly Random _random;
        private const int SidesCount = 6;

        public Dice(Random random)
        {
            //SidesCount = SidesCount; If need dev to give sides number
            _random = random;
        }

        public int Roll()
        {
            return _random.Next(1, SidesCount + 1);
        }

        public void Describe() => Console.WriteLine($"This dice has {SidesCount} sides");
    }
}
