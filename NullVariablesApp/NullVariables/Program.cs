namespace NullVariables;
class Program
{
    static void Main(string[] args)
    {
        //null - is a keyword to indicate lack of value
        //To make a datatype nullable(store null) add ? , not required with string but ideal to add.
        int? age = null;
        Console.WriteLine(age);
        Console.ReadLine();
    }
}

