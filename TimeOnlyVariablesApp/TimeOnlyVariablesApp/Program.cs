namespace TimeOnlyVariablesApp;
class Program
{
    static void Main(string[] args)
    {
        TimeOnly opensAt = TimeOnly.Parse("8:00 AM");
        TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);
        Console.WriteLine(rightNow);
        Console.WriteLine(opensAt);
        Console.ReadLine();
    }
}

