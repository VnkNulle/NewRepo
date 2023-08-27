using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine("First List: " + string.Join(",", firstList));

            var secondList = new List<string>
            {
                "Yellow",
                "Blue",
                "Purple",
                "Orange"
            };

            Console.WriteLine("Second List: " + string.Join(",", secondList));

            var joinedList = firstList.Concat(secondList);

            Console.WriteLine("Joined List: " + string.Join(",", joinedList));
        }
    }
}
