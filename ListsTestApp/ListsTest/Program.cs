

//define variables
List<string> firstNames = new List<string>();
bool toExit = true;

do
{
    Console.Clear();
    Console.Write("Do you want start entering names? If so enter y or press any key: ");
    string decision = "";
    decision = Console.ReadLine();
    if (decision.ToLower() == "y")
    {
        toExit = false;
    }
    else
    {
        toExit = true;
    }
if (toExit == false)
    {
        Console.Write("Please enter the student firstName: ");
        string? name = "";
        Console.ReadLine();
        firstNames.Add(name);
    }
} while (toExit == false);
Console.WriteLine("Thanks for using the app.");
Console.WriteLine($"The total number of students entered is: {firstNames.Count}");
Console.ReadLine();
