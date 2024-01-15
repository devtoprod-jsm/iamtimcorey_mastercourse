namespace AdvancedIf;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        string? firstName = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string? lastName = Console.ReadLine();
        Console.Write("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());
/*
        if (firstName.ToLower() == "jaisrith" && lastName.ToLower() == "tella")
        {
            Console.WriteLine("You have a beautiful name.");
        }
        else if (firstName.ToLower() == "jaisrith")
        {
            Console.WriteLine("You have a beautiful first name.");
        }
        else if (lastName.ToLower() == "tella")
        {
            Console.WriteLine("You have a beautiful last name.");
        }
        else
        {
            Console.WriteLine("You don't have a beautiful name.");
        }
*/

        if (firstName.ToLower() == "jaisrith")
        {
            Console.WriteLine("You have a nice first name");
        }
        if (lastName.ToLower() == "tella")
        {
            Console.WriteLine("You have a nice last name");
        }
        else
        {
            Console.WriteLine("Sorry");
        }

        if ((age >= 30 && age <35) || (age >= 35 && age < 40))
        {
            Console.WriteLine("You are in your 30s.");
        }
        else
        {
            Console.WriteLine("You are not my age group.");
        }
        Console.ReadLine();
    }
}

