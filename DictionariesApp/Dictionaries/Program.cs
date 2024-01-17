


Dictionary<string, string> lookup = new Dictionary<string, string>();
lookup["animal"] = "Not a human";
lookup["fish"] = "not a human that swims";
lookup["human"] = "us";
Console.WriteLine($"The definition for fish is: {lookup["fish"]}");

Dictionary<int, string> employees = new Dictionary<int, string>();
employees[2018] = "jai";
employees[1992] = "sind";
employees[1987] = "mo";
Console.WriteLine($"The employee with id 2018 is: {employees[2018]}");

Dictionary<string, int> dayOfWeek = new Dictionary<string, int>();
dayOfWeek["Sunday"] = 1;
dayOfWeek["Monday"] = 2;
dayOfWeek["Tuesday"] = 3;
dayOfWeek["Wednesday"] = 4;
dayOfWeek["Thursday"] = 5;
dayOfWeek["Friday"] = 6;
dayOfWeek["Saturday"] = 7;
Console.WriteLine($"The day of week for Wednesday is: {dayOfWeek["Wednesday"]}");

Console.ReadLine();



