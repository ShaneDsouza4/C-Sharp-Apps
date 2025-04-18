Console.WriteLine("Welcome to the calculator app");

Console.WriteLine("Enter your first number: ");
string num1 = Console.ReadLine();
float num1AsDigit = float.Parse(num1);

Console.WriteLine("Enter your second Number:");
string num2 = Console.ReadLine();
float num2AsDigit = float.Parse(num2);

Console.WriteLine("What type of operation do you want to perform ?");
Console.WriteLine("Please Enter 'a' for addition. 's' for subtraction, 'm' for multiplication, 'd' for division.");
string operation = Console.ReadLine().ToLower();

float result = 0;

switch (operation)
{
    case "a":
        result = num1AsDigit + num2AsDigit;
        break;
    case "m":
        result = num1AsDigit * num2AsDigit;
        break;
    case "s":
        result = num1AsDigit - num2AsDigit;
        break;
    case "d":
        result =  num2AsDigit == 0 ? float.NaN : num1AsDigit / num2AsDigit;
        if (float.IsNaN(result))
        {
            Console.WriteLine("Cannot divide by 0");
        }
        break;
    default:
        Console.WriteLine("Invalid operation");
        break;
}

Console.WriteLine("Result: " + result);
Console.WriteLine("Thank you for using this calculator app.");

Console.ReadKey();