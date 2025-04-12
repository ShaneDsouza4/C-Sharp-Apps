int playerHp = 40;
int enemyHp = 20;

int playerAttack = 5;
int enemyAttack = 7;

int healAmount = 5;

Random random = new Random();

while (playerHp > 0 && enemyHp > 0)
{
    //Player turn
    Console.WriteLine(" ");
    Console.WriteLine("****Player Turn****");
    Console.WriteLine($"Player HP: {playerHp}. Enemy HP: {enemyHp}");
    Console.WriteLine("Press 'a' to attack or 'h' to heal.");

    string choice = Console.ReadLine();

    if (choice == "a")
    {
        enemyHp -= playerAttack;
        Console.WriteLine($"Player attacked enemey. Damage done: {playerAttack}");
    }
    else if (choice == "h")
    {
        playerHp += healAmount;
        Console.WriteLine($"Player has restored. Health Points: {playerHp}");
    }

    //Enemy Turn
    if (enemyHp > 0)
    {
        Console.WriteLine(" ");
        Console.WriteLine("****Enemy Turn****");
        Console.WriteLine($"Player HP: {playerHp}. Enemy HP: {enemyHp}");
        int enemyChoice = random.Next(0, 1);

        if (enemyChoice == 0)
        {
            playerHp -= enemyAttack;
            Console.WriteLine($"Enemy attacked player. Damage done: {enemyAttack}");
        }
        else if (enemyChoice == 1)
        {
            enemyHp += healAmount;
            Console.WriteLine($"Enemy has restored. Health Points: {enemyHp}");
        }
    }
}

Console.WriteLine(" ");
if (playerHp > 0)
{
    Console.WriteLine("Congratulations! You have won.");
}
else
{
    Console.WriteLine("You lost :(");
}

Console.ReadKey();
