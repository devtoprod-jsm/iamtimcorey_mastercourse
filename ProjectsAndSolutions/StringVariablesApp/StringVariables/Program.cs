namespace StringVariables;
class Program
{
    static void Main(string[] args)
    {
        string firstName = string.Empty;
        string lastName = string.Empty;
        string filePath = string.Empty;

        firstName = "Jaisrith";
        lastName = "Tella";
        //filePath = "C:\\Temp\\Demo";
        filePath = @"C:\Temp\Demo";

        //Console.WriteLine(firstName + " " + lastName);
        string testString = $@"The file for {firstName} is C:\Temp\Demo\{firstName}";
        Console.WriteLine($"Hello {firstName} {lastName}");
        Console.WriteLine(filePath);
        Console.WriteLine(testString);
        Console.ReadLine();
    }
}