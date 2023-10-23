using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumbers = GenerateRandomNumbers(20);

            Console.Write("Enter a number (1-20): ");
            int position = int.Parse(Console.ReadLine());

            if (position >= 1 && position <= 20)
            {
                int number = randomNumbers[position - 1];
                Console.WriteLine($"Number at position {position}: {number}");
            }
            else
            {
                Console.WriteLine("Error! Please enter a number between 1 and 20.");
            }

            Console.ReadKey();
        }

        static int[] GenerateRandomNumbers(int count)
        {
            Random random = new Random();
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(1, 101);
            }

            return numbers;
        }
    }
}
