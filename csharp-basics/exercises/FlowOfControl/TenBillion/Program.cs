using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");
            var input = Console.ReadLine();

            if (long.TryParse(input, out long number))
            {
                number = Math.Abs(number);

                if (number < 10000000000)
                {
                    int digitCount = number == 0 ? 1 : (int)Math.Log10(number) + 1;
                    Console.WriteLine($"The number has {digitCount} digit(s).");
                }
                else
                {
                    Console.WriteLine("The number should be less than ten billion (10,000,000,000).");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
