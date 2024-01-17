namespace Lists;
class Program
{
    static void Main(string[] args)
    {
        //string[] firstNames = new string[5];
        List<string> firstNames = new List<string>();
        firstNames.Add("Jai");
        firstNames.Add("Sind");
        firstNames.Add("Mo");
        Console.WriteLine(firstNames[firstNames.Count - 1]);
        string data = "tella,nangineni";
        List<string> lastNames = data.Split(",").ToList();
        lastNames.Add("jagarlamudi");
        Console.WriteLine(lastNames[0]);
        Console.ReadLine();
    }
}

