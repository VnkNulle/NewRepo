using System;

namespace Exercise7
{
    class Piglet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");

            int totalScore = 0;
            bool continuePlaying = true;

            while (continuePlaying)
            {
                int roll = RollDice();
                if (roll == 1)
                {
                    Console.WriteLine("You rolled a 1!");
                    totalScore = 0;
                    continuePlaying = false;
                }
                else
                {
                    Console.WriteLine($"You rolled a {roll}!");
                    totalScore += roll;
                    Console.Write("Roll again? (yes/no) ");
                    string input = Console.ReadLine().ToLower();
                    if (input != "yes")
                    {
                        continuePlaying = false;
                    }
                }
            }

            Console.WriteLine($"You got {totalScore} points.");
        }

        static int RollDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}
