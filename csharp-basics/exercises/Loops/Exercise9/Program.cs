using System;

namespace RollTwoDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Desired sum: ");
            int desiredSum = int.Parse(Console.ReadLine());

            Random random = new Random();
            int roll1, roll2, sum;

            do
            {
                roll1 = random.Next(1, 7);
                roll2 = random.Next(1, 7);
                sum = roll1 + roll2;

                Console.WriteLine($"{roll1} and {roll2} = {sum}");
            }
            while (sum != desiredSum);
        }
    }
}
