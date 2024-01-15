namespace DoWhileLoop;
class Program
{
    static void Main(string[] args)
    {
        bool isValidAge;
        int age;
        do
        {
            Console.Clear();
            Console.WriteLine("What is your age? ");
            string? ageText = Console.ReadLine();
            isValidAge = int.TryParse(ageText, out age);
            if (isValidAge == false)
            {
                Console.WriteLine("Press Enter and input a valid age.");
                Console.ReadLine();
            }
        } while (isValidAge == false);
        Console.ReadLine();
    }
}

