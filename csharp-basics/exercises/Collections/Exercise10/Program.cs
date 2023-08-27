using System;
using System.Collections.Generic;

namespace HashSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> valuesSet = new HashSet<string>
            {
                "Apple",
                "Banana",
                "Cherry",
                "Date",
                "Fig"
            };

            Console.WriteLine("Items in the set:");
            foreach (string item in valuesSet)
            {
                Console.WriteLine(item);
            }

            valuesSet.Clear();
            Console.WriteLine("\nSet after clearing:");
            Console.WriteLine(string.Join(", ", valuesSet));

            valuesSet.Add("Apple");
            valuesSet.Add("Banana");

            Console.WriteLine("\nSet after adding duplicated values:");
            Console.WriteLine(string.Join(", ", valuesSet));
        }
    }
}
