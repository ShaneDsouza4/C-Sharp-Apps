Console.WriteLine("Welcome! Please enter 'c' to use the currency converter or any other key to use the temperature converter");

string answer = Console.ReadLine();

if(answer == "c")
{
    Console.WriteLine("You have selected the currency converter");
    Console.WriteLine("Please enter 'a' to convert from Pounds or any other key to convert from Euros");
    string choice = Console.ReadLine();

    if(choice == "a")
    {
        Console.WriteLine("Please enter your amount in British Pounds");
        float pounds = float.Parse(Console.ReadLine());
        float euros = pounds * 1.16f;
        Console.WriteLine("The amount in Euros is " + euros.ToString("0.00"));
    }
    else
    {
        Console.WriteLine("Please enter your amount in Euros");
        float euros = float.Parse(Console.ReadLine());
        float pounds = euros / 1.16f;
        Console.WriteLine("The amount in British Pounds is " + pounds.ToString("0.00"));
    }
}
else
{
    Console.WriteLine("Welcome to the temperature converter");
    Console.WriteLine("Please enter 'a' to convert from Celcius or any other key to convert from Farenheit");
    string choice = Console.ReadLine();

    if (choice == "a") {
        Console.WriteLine("Enter a temperature in Celcius");
        float celcius = float.Parse(Console.ReadLine());
        float farhenheit = celcius * 1.18f + 32f;
        Console.WriteLine("The temperature in Farenheit is " + farhenheit);
    }
    else
    {
        Console.WriteLine("Enter a temperature in Fareheit");
        float farhenheit = float.Parse(Console.ReadLine());
        float celcius = (farhenheit - 32f) / 1.18f;
        Console.WriteLine("The temperature in Celciu is " + celcius);
    }
}

Console.ReadKey();