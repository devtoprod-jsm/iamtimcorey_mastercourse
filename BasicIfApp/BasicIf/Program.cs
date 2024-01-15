namespace BasicIf;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string? firstName = Console.ReadLine();
        string? lastName;
        if (firstName.ToLower() == "jaisrith")
        {
            Console.WriteLine("Hello Tella");
            lastName = "Tella";
        }
        else
        {
            Console.WriteLine($"Hello {firstName}");
            lastName = "Other";
        }
        Console.WriteLine(lastName);
        Console.ReadLine();
    }
}

