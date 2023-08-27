using System;
using System.Collections.Generic;

namespace HappyNumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            bool isHappy = IsHappyNumber(number);

            if (isHappy)
                Console.WriteLine($"{number}happy");
            else
                Console.WriteLine($"{number}not happy");
        }

        static bool IsHappyNumber(int num)
        {
            HashSet<int> seenNumbers = new HashSet<int>();

            while (num != 1 && !seenNumbers.Contains(num))
            {
                seenNumbers.Add(num);
                num = CalculateSumOfSquares(num);
            }

            return num == 1;
        }

        static int CalculateSumOfSquares(int num)
        {
            int sum = 0;

            foreach (char digitChar in num.ToString())
            {
                int digit = int.Parse(digitChar.ToString());
                sum += (int)Math.Pow(digit, 2);
            }

            return sum;
        }
    }
}
