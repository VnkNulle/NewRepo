using System;

namespace SumOfSingleDigitNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of single-digit numbers. Separated with spaces:");
            string input = Console.ReadLine();
            int sum = 0;

            string[] numbers = input.Split(' ');

            foreach (string numberStr in numbers)
            {
                if (int.TryParse(numberStr, out int number))
                {
                    if (number >= 0 && number <= 9)
                    {
                        sum += number;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input: " + numberStr + " is not a single-digit number.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input: " + numberStr + " is not a valid number.");
                    return;
                }
            }

            Console.WriteLine("The sum of all the numbers is: " + sum);
        }
    }
}
