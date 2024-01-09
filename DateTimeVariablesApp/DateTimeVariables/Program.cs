using System.Globalization;

namespace DateTimeVariables;
class Program
{
    static void Main(string[] args)
    {
        //DateTime today = DateTime.Now;
        DateTime today = DateTime.UtcNow;
        //DateTime birthday = DateTime.Parse("9/20/2018");
        DateTime birthday = DateTime.ParseExact("20/9/2018", "d/M/yyyy",CultureInfo.InvariantCulture);
        Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz"));
        Console.WriteLine(birthday);
        Console.ReadLine();
    }
}

