using System;

class PrintDayInWord
{
    static void Main()
    {
        Console.Write("Enter the day number (0-6): ");
        int dayNumber = int.Parse(Console.ReadLine());

        if (dayNumber == 0)
        {
            Console.WriteLine("Sunday");
        }
        else if (dayNumber == 1)
        {
            Console.WriteLine("Monday");
        }
        else if (dayNumber == 2)
        {
            Console.WriteLine("Tuesday");
        }
        else if (dayNumber == 3)
        {
            Console.WriteLine("Wednesday");
        }
        else if (dayNumber == 4)
        {
            Console.WriteLine("Thursday");
        }
        else if (dayNumber == 5)
        {
            Console.WriteLine("Friday");
        }
        else if (dayNumber == 6)
        {
            Console.WriteLine("Saturday");
        }
        else
        {
            Console.WriteLine("Not a valid day");
        }
    }
}
