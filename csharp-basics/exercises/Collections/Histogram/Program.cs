using System;
using System.IO;

namespace Histogram
{
    class Program
    {
        private const string Path = "../Histogram/midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            int[] scoreCount = new int[11];

            foreach (var score in readText)
            {
                if (int.TryParse(score, out int parsedScore))
                {
                    if (parsedScore < 0)
                        scoreCount[0]++;
                    else if (parsedScore > 100)
                        scoreCount[10]++;
                    else
                        scoreCount[parsedScore / 10]++;
                }
            }

            Console.WriteLine("Histogram:");

            for (int i = 0; i < scoreCount.Length; i++)
            {
                string range;
                if (i == 0)
                    range = "00-09";
                else if (i == 10)
                    range = "  100";
                else
                    range = $"{i * 10:00}-{i * 10 + 9:00}";

                string stars = new string('*', scoreCount[i]);
                Console.WriteLine($"{range}: {stars}");
            }
        }
    }
}
