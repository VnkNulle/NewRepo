using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ArraysHangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var words = new List<string>
            {
                "Krieg",
                "Yarrik",
                "Horus",
                "Lionel",
                "Nurgle"
            };

            var allowMisses = 5;
            var MissedLetters = string.Empty;
            var word = words[random.Next(words.Count)];
            var wordForDisplay = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                wordForDisplay[i] = '_';
            }

            while (wordForDisplay.Contains('_') && allowMisses >= 0)
            {
                Console.WriteLine("Guess the word.");
                Console.WriteLine($"Word: {new string(wordForDisplay)}");
                Console.WriteLine($"Misses: {MissedLetters}");
                Console.WriteLine();
                Console.Write("Guess:");

                var input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                var regex = new Regex("[a-zA-Z]");
                var isMatch = regex.IsMatch(input.ToString());
                if (!isMatch)
                {
                    Console.WriteLine("Please enter a single letter.");
                    continue;
                }

                char guessedLetter = char.ToLower(input);

                if (MissedLetters.Contains(guessedLetter) || new string(wordForDisplay).Contains(guessedLetter))
                {
                    Console.WriteLine("You already guessed this letter.");
                    continue;
                }

                if (word.ToLower().Contains(guessedLetter))
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (char.ToLower(word[i]) == guessedLetter)
                        {
                            wordForDisplay[i] = word[i];
                        }
                    }
                }
                else
                {
                    MissedLetters += guessedLetter;
                    allowMisses--;
                }
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            }

            Console.WriteLine(word);

        }
    }
}
