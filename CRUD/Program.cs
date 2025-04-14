Console.WriteLine("Welcome to the CRUD App");
List<string> TaskList = new List<string>();
string option = "";

while (option != "e")
{
    Console.WriteLine("What would you like to do ?");
    Console.WriteLine("Press 1 to Add");
    Console.WriteLine("Press 2 to Remove");
    Console.WriteLine("Press 3 to View");
    Console.WriteLine("Press e to Exit");


    option = Console.ReadLine();

    if(option == "1")
    {
        Console.WriteLine("Please enter the name of the task: ");
        string task = Console.ReadLine();
        TaskList.Add(task);
    }
    else if (option == "2")
    {
        for (int i = 0; i < TaskList.Count; i++)
        {
            Console.WriteLine(i + ": " + TaskList[i]);
        }
        Console.WriteLine("Please enter the task number to remove from the list: ");
        int taskNumber = Convert.ToInt32(Console.ReadLine());
        TaskList.RemoveAt(taskNumber);
    }
    else if (option == "3")
    {
        Console.WriteLine("Current Tasks in the list are;");
        for (int i = 0; i < TaskList.Count; i++)
        {
            Console.WriteLine(i + ": " + TaskList[i]);
        }
    }
    else if(option == "e")
    {
        Console.WriteLine("Exiting the program.");
    }
    else
    {
        Console.WriteLine("Invalid Option. Please try again.");
    }
}

Console.WriteLine("Thank you for using the CRUD App to add Tasks.");