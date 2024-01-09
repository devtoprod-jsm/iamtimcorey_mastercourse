namespace TypeConversion;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your age?: ");
        string? ageText = Console.ReadLine();
        //Console.WriteLine(ageText + 15);
        //int age = int.Parse(ageText);

        bool isValidInt = int.TryParse(ageText, out int age);
        Console.WriteLine($"The input value: {ageText} and can be converted: {isValidInt}");
        Console.WriteLine(age + 15);
        double testDouble = age;
        decimal testDecimal = (decimal)testDouble; //explicit casting
        Console.ReadLine();
    }
}

