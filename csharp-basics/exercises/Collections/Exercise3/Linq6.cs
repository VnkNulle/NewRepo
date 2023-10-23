using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise6
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

            Console.WriteLine(string.Join(",", colors));

            colors = colors.Where((color, index) => index != 2).ToList();

            Console.WriteLine("After removing third element from the list:");
            Console.WriteLine(string.Join(",", colors));
        }
    }
}
