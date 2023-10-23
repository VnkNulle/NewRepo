using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise3
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

            colors.Insert(0, "Blue");
            colors.Insert(2, "Yellow");

            Console.WriteLine(string.Join(",", colors));
        }
    }
}
