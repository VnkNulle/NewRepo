using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            bool containsWhite = colors.Any(color => color == "White");

            Console.WriteLine("Does the list contain 'White'? " + containsWhite);
        }
    }
}
