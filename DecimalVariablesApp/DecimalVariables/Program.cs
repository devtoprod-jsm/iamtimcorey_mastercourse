namespace DecimalVariables;
class Program
{
    static void Main(string[] args)
    {
        // double and decimal vary in precision
        //decimal is more precise and obviously more expensive (bits used)
        decimal bankAccountBalance;
        //M at the end to indicate the number is decimal and not double
        bankAccountBalance = 2.0M / 3; 
        Console.WriteLine(bankAccountBalance);
        Console.ReadLine();
    }
}

