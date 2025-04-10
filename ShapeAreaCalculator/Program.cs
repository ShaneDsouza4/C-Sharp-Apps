Console.WriteLine("What shape would you like to find the area of ?");
Console.WriteLine("Please enter 'r' for rectangle.");
Console.WriteLine("Please enter any key for circle.");

var userChoice = Console.ReadLine();
float result;

if(userChoice == "r")
{
    Console.WriteLine("Enter height of recatangle: ");
    float height = float.Parse(Console.ReadLine());

    Console.WriteLine("Enter width of rectangle");
    float width = float.Parse(Console.ReadLine());

    result = height * width;

}
else
{
    Console.WriteLine("Enter radius of circle: ");
    float radius = float.Parse(Console.ReadLine());

    result = (float)Math.PI * radius;
}

Console.WriteLine($"The result is {result}");


Console.ReadKey();