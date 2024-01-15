namespace StudentCheck;
class Program
{
    static void Main(string[] args)
    {
        //Ask user for their name
        Console.Write("What is your firstname? ");
        string? firstName = Console.ReadLine();

        //Ask user for their age
        Console.Write("What is your age? ");
        int age = Convert.ToInt32(Console.ReadLine());

        //If their name is bob or sue, address them as professor
        switch (firstName.ToLower()) {
            case "bob" or "sue":
                Console.WriteLine("Hello Professor");
                break;
            default:
                Console.WriteLine($"Hello {firstName}");
                break;
        }
        //If the person is under 21 ask them to wait for x years until they are 21
        if (age < 21 ) //&& (firstName.ToLower() != "bob" || firstName.ToLower() != "sue"))
        {
            int waitTime = 21 - age;
            Console.WriteLine($"You need to wait {waitTime} year(s) to attend this course");
        }
        else
        {
            Console.WriteLine($"Welcome to your new course {firstName}");
        }
        Console.ReadLine();
    }
}

