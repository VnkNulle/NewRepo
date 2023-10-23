using System;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../lear.txt";
            int lineCount = 0;
            int wordCount = 0;
            int charCount = 0;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lineCount++;
                        charCount += line.Length;
                        wordCount += CountWords(line);
                    }
                }

                Console.WriteLine($"Lines = {lineCount}");
                Console.WriteLine($"Words = {wordCount}");
                Console.WriteLine($"Chars = {charCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static int CountWords(string text)
        {
            int wordCount = 0;
            bool insideWord = false;

            foreach (char c in text)
            {
                if (char.IsLetterOrDigit(c))
                {
                    if (!insideWord)
                    {
                        insideWord = true;
                        wordCount++;
                    }
                }
                else
                {
                    insideWord = false;
                }
            }

            return wordCount;
        }
    }
}
