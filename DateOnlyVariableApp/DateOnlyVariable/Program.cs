namespace DateOnlyVariable;
class Program
{
    static void Main(string[] args)
    {
        DateTime today = DateTime.Now;
        DateOnly birthday = DateOnly.ParseExact("20/09/2018","dd/MM/yyyy");

        Console.WriteLine(birthday.ToString("MMMM dd, yyyy"));
        Console.WriteLine(birthday);

        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Today full format {today}");
        Console.WriteLine($"Today just date part {today.Date}");
        Console.WriteLine($"Birthday full format {birthday}");
        Console.ReadLine();
    }
}

