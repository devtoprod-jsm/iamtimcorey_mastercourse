namespace ArraysTest;
class Program
{
    static void Main(string[] args)
    {
        int number;
        bool isDigit;
        string[] firstNames = new string[] { "jai", "sind", "mo" };
        bool toExit = true;
        do
        {
            Console.Clear();
            //Ask user for a number to return the name from array
            Console.Write("Please enter a number between 1 and 3: ");
            string? numberText = Console.ReadLine();
            isDigit = int.TryParse(numberText, out number);
            // Check whether the number is digit or in between 1 and 3
            if (isDigit && number >=1 && number <= 3)
            {
                Console.WriteLine($"The selected name is {firstNames[number - 1]}");
            }
            else
            {
                Console.WriteLine("Sorry wrong input enter between 1 and 3, it should be digits");
            }
            Console.Write("If you want to continue press 'y' and enter twice or to exit press enter thrice: ");
            string? toContinue = Console.ReadLine();
            if (toContinue.ToLower() == "y")
            {
                toExit = false;
            }
            Console.ReadLine();

        } while (toExit == false);
        Console.ReadLine();
    }
}

