using System;

Console.WriteLine("Welcome");
bool isUserExitRequested = false;
List<string> TODOs = new List<string>();

do
{
    MenuDetails();
    var userChoice = Console.ReadLine();
    validateUserInput(userChoice);


    if (userChoice == "E" || userChoice == "e")
    {
        isUserExitRequested = true;
    }

    if(userChoice == "A" || userChoice == "a")
    {
        AddTodo();
    }

    if (userChoice == "S" || userChoice == "s")
    {
        SeeAllTodos();
    }

    if (userChoice == "R" || userChoice == "r")
    {
        RemoveTodo();
    }

} while (!isUserExitRequested);


void MenuDetails()
{
    Console.WriteLine("");
    Console.WriteLine("***********************");
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    Console.WriteLine("");
    Console.WriteLine("Enter your option: ");
}

void validateUserInput(string userInput)
{
    if(userInput.Length <= 0)
    {
        Console.WriteLine("Incorrect Input. Please try again");
    }
}

void AddTodo()
{
    Console.WriteLine("");
    Console.WriteLine("Enter the TODO description:");
    var description = Console.ReadLine();

    if(description.Length <= 0)
    {
        Console.WriteLine("The description cannot be empty.");
        AddTodo();
    }

    if (TODOs.Contains(description))
    {
        Console.WriteLine("The description must be unique.");
        AddTodo();
    }

    TODOs.Add(description);

    Console.WriteLine("TODO successfully added: " + description);
}

void SeeAllTodos()
{
    Console.WriteLine("");
    Console.WriteLine("All the TODOs");
    if(TODOs.Count <= 0)
    {
        Console.WriteLine("No TODOs have been added yet;");
        MenuDetails();
    }

    for (int i = 0; i < TODOs.Count; i++)
    {
        Console.WriteLine(i + 1 + ". " + TODOs[i]);
    }
}

void RemoveTodo()
{
    Console.WriteLine("");
    SeeAllTodos();
    Console.WriteLine("Select the index of the TODO you want to remove:");


    var todoToRemove = Console.ReadLine();
    bool isParsingSuccesfull = int.TryParse(todoToRemove, out int number);
    if (isParsingSuccesfull)
    {
        int index = number - 1;

        if(index >= 0 && index < TODOs.Count)
        {
            TODOs.RemoveAt(index);
            Console.WriteLine("Todo Removed Succesfuly.");
            SeeAllTodos();
        }
        else
        {
            Console.WriteLine("Invalid Index");
            Console.WriteLine("No TODO is removed.");
            RemoveTodo();
        }
        
    }
    else
    {
        Console.WriteLine("Enter a valid index number.");
        RemoveTodo();
    }
}

Console.ReadKey();
