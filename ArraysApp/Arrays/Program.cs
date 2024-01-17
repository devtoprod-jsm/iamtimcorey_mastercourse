namespace Arrays;
class Program
{
    static void Main(string[] args)
    {
        string firstNamesString = "Jai,Sin,Mo";
        string[] firstNames = firstNamesString.Split(",");
        Console.WriteLine(firstNames[firstNames.Length - 1]);
        string[] lastNames = new string[] { "tella", "nangineni" };
        Console.ReadLine();
    }
}

