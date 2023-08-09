using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first word: ");
            string firstWord = Console.ReadLine();

            Console.Write("Enter second word: ");
            string secondWord = Console.ReadLine();

            int totalLength = 30;
            int dotsCount = totalLength - (firstWord.Length + secondWord.Length);

            Console.Write(firstWord);

            for (int i = 0; i < dotsCount; i++)
            {
                Console.Write(".");
            }

            Console.WriteLine(secondWord);
        }
    }
}
