using System;

class Program
{
    // 2. Define DayOfWeek enum with explicit values
    enum DayOfWeek { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

    static void Main()
    {
        
        Console.Write("Enter a day number (1-7): ");
        int input = int.Parse(Console.ReadLine());

   
        string dayName = Enum.GetName(typeof(DayOfWeek), input);
        DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayName);

        Console.WriteLine($"Day: {day}");
    }
}

/* 
3. Answer to question:
If the user enters a value outside 1-7:
- Enum.GetName() returns null for invalid numbers
- Enum.Parse() throws ArgumentNullException when trying to parse a null value
- This results in a runtime exception:
   "System.ArgumentNullException: Value cannot be null."
*/