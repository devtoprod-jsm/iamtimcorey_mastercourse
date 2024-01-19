

List<string> firstNames = new List<string>();
bool noMoreEntries = false;
do
{
    Console.Write("If you want to enter firstName please press 'y' or press any other key: ");
    string? decision = Console.ReadLine();
    if (decision.ToLower() == "y")
    {
        Console.Write("Please enter the firstname: ");
        firstNames.Add(Console.ReadLine());

    }

    else
    {
        noMoreEntries = true;
    }
   
} while (noMoreEntries == false);
if (firstNames.Count == 0)
{
    Console.WriteLine("Sorry no entries found.");
}
else
{
    foreach (string firsName in firstNames)
    {
        Console.WriteLine($"Hello {firsName}");
    }
}
Console.ReadLine();