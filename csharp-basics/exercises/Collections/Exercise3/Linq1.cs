using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> colorsList = new List<string>
            {
                "Red",
                "Green",
                "Blue",
                "Yellow",
                "Purple"
            };

            Console.WriteLine("Colors in the list:");
            foreach (string color in colorsList)
            {
                Console.WriteLine(color);
            }
        }
    }
}
