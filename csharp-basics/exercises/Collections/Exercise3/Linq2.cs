using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            colors.ForEach(color => Console.WriteLine(color));
        }
    }
}
