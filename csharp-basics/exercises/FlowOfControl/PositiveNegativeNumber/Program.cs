﻿namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            var input = Console.ReadLine();

            int number = int.Parse(input);

            if (number > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }

        }
    }
}