using System;

namespace CountUppercaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string input = Console.ReadLine();

            int uppercaseCount = CountUppercaseLetters(input);
            Console.WriteLine("Number of uppercase letters in word: " + uppercaseCount);
        }

        static int CountUppercaseLetters(string str)
        {
            int count = 0;

            foreach (char c in str)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
