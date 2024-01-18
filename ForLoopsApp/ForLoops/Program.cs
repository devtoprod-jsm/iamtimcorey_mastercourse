


string data = "jai,sind,mo";
List<string> firstNames = new();
firstNames = data.Split(",").ToList();
for (int i=0; i < firstNames.Count; i++)
{
    Console.WriteLine($"Hello {firstNames[i]}");
}
decimal total=0;
List<decimal> deposits = new();
deposits.Add(12.88M);
deposits.Add(88.12M);
deposits.Add(123);
for (int i=0; i < deposits.Count; i++)
{
    total += deposits[i];
}
Console.WriteLine($"The total deposit is {total}");
Console.ReadLine();

