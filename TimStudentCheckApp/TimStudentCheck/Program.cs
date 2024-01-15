namespace TimStudentCheck;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string? firstName = Console.ReadLine();
        Console.Write("What is your age? ");
        string? ageText = Console.ReadLine();
        string? formattedName;

        if (int.TryParse(ageText,out int age) == false)
        {
            Console.WriteLine("Please enter right age in numbers format");
            return;
        }

        if (firstName.ToLower() == "sue" || firstName.ToLower() == "bob")
        {
            formattedName = $"Professor {firstName}";
        }
        else
        {
            formattedName = firstName;
        }
        if (age < 21)
        {
            Console.WriteLine($"You need to wait {21 - age} years {formattedName}");
        }
        else
        {
            Console.WriteLine($"Welcome {formattedName}");
        }

        /*      if(int.TryParse(ageText,out int age))
              {
                  if(firstName.ToLower() == "sue" || firstName.ToLower() == "bob")
                  {
                     formattedName = $"Professor {firstName}" ;
                  }
                  else
                  {
                      formattedName = firstName;
                  }
                  if(age < 21)
                  {
                      Console.WriteLine($"You need to wait {21-age} years {formattedName}"); 
                  }
                  else
                  {
                     Console.WriteLine($"Welcome {formattedName}");
                  }
              }
              else
              {
                  Console.WriteLine("Please enter the right age in numbers");
              }
        */
        Console.ReadLine();
    }
}

