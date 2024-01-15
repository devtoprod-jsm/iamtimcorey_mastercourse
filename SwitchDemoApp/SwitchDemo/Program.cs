namespace SwitchDemo;
class Program
{
    static void Main(string[] args)
    {
        string name = "jai";
        int age = 6;

        switch (age)
        {
            case >= 0 and < 18:
                Console.WriteLine("You are young for a job");
                break;
            case >= 18 and < 66:
                Console.WriteLine("You are up for work.");
                break;
            default:
                Console.WriteLine("Sorry no job.");
                break;
        }
        Console.ReadLine();
    }
}

