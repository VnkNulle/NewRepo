using System;
using System.Collections.Generic;

namespace UniqueNameList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> uniqueNames = new List<string>();

            Console.WriteLine("Enter names (one per line). Press Enter to finish.");
            string input;
            do
            {
                Console.Write("Enter name: ");
                input = Console.ReadLine().Trim();

                if (!string.IsNullOrEmpty(input))
                {
                    if (!uniqueNames.Contains(input))
                    {
                        uniqueNames.Add(input);
                    }
                }

            } while (!string.IsNullOrEmpty(input));

            Console.WriteLine("Unique name list contains: " + string.Join(" ", uniqueNames));
        }
    }
}
