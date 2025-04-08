Console.WriteLine("Welcome to the calculator app");

Console.WriteLine("Enter your first number: ");
string num1 = Console.ReadLine();
int num1AsDigit = Convert.ToInt32(num1);

Console.WriteLine("Enter your second Number:");
string num2 = Console.ReadLine();
int num2AsDigit = int.Parse(num2);

Console.WriteLine("What type of operation do you want to perform ?");
Console.WriteLine("Please Enter 'a' for addition. 's' for subtraction, 'm' for multiplication, 'd' for division.");
string operation = Console.ReadLine();

int result = 0;

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
        result = num1AsDigit / num2AsDigit;
        break;
    default:
        Console.WriteLine("Invalid operation");
        break;
}

Console.WriteLine("Result: " + result);
Console.WriteLine("Thank you for using this calculator app.");

Console.ReadKey();