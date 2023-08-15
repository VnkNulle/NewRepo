using System;
using System.Globalization;

class Date
{
    public static string GetDutchWeekdayName(int year, int month, int day)
    {
        CultureInfo dutchCulture = CultureInfo.GetCultureInfo("nl-NL");
        DateTime date = new DateTime(year, month, day);
        string weekdayName = dutchCulture.DateTimeFormat.DayNames[(int)date.DayOfWeek];
        return weekdayName;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());

        Console.Write("Enter the month: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter the day: ");
        int day = int.Parse(Console.ReadLine());

        string weekdayName = Date.GetDutchWeekdayName(year, month, day);
        Console.WriteLine($"The Dutch weekday name for {day}/{month}/{year} is {weekdayName}.");
    }
}
