namespace DoWhileLoopTest;
class Program
{
    static void Main(string[] args)
    {
        string? firstName = "";
        string? wantToExit = "";
        do
        {
            Console.Clear();
            Console.Write("Please enter your name: ");
            firstName = Console.ReadLine();
            if (firstName.ToLower() == "jai")
            {
                Console.WriteLine($"Hello professor {firstName}");
            }
            else
            {
                Console.WriteLine($"Hello {firstName}");
            }
            Console.Write("If you want to exit type in yes or y or exit: ");
            wantToExit = Console.ReadLine();
            Console.WriteLine(wantToExit);
            Console.ReadLine();
        } while (wantToExit.ToLower() != "yes" && wantToExit.ToLower() != "exit" && wantToExit.ToLower() != "y");
        Console.ReadLine();
    }
}

