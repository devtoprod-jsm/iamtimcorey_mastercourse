namespace IntVariables;
class Program
{
    static void Main(string[] args)
    {
        //Yes 2, 28, 2678, -48
        //No 6.5, -18.98

        int age = 0;
        age = 43;
        int ageInTenYears = 43 + 10;

        //Two billion +/-
        //Signed Int32
        //UnSigned UInt32 4billion..
        //bit - 0 or 1
        //byte - 8bits
        //Int16,Int32,Int64
        Console.WriteLine(age);
        Console.WriteLine(ageInTenYears);
        //Don't do this with ints - Console.WriteLine(age/2);
        Console.ReadLine();
    }
}

