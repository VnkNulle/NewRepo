using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Century(1756)); // ➞ "18th century"
        Console.WriteLine(Century(1555)); // ➞ "16th century"
        Console.WriteLine(Century(1000)); // ➞ "10th century"
        Console.WriteLine(Century(1001)); // ➞ "11th century"
        Console.WriteLine(Century(2005)); // ➞ "21st century"
    }

    static string Century(int year)
    {
        int century = (year - 1) / 100 + 1;
        string suffix;

        switch (century % 10)
        {
            case 1:
                suffix = "st";
                break;
            case 2:
                suffix = "nd";
                break;
            case 3:
                suffix = "rd";
                break;
            default:
                suffix = "th";
                break;
        }

        if (century >= 11 && century <= 13)
        {
            suffix = "th";
        }

        return century + suffix + " century";
    }
}
