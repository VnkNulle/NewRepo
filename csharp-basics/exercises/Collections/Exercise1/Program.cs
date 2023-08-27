using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            List<string> list = new List<string>(array);
            Console.WriteLine("Using List:");
            foreach (string brand in list)
            {
                Console.WriteLine(brand);
            }
            Console.WriteLine();

            HashSet<string> hashSet = new HashSet<string>(array);
            Console.WriteLine("Using HashSet:");
            foreach (string brand in hashSet)
            {
                Console.WriteLine(brand);
            }
            Console.WriteLine();

            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                { "Audi", "Germany" },
                { "BMW", "Germany" },
                { "Honda", "Japan" },
                { "Mercedes", "Germany" },
                { "VolksWagen", "Germany" },
                { "Tesla", "USA" }
            };

            Console.WriteLine("Using Dictionary:");
            foreach (KeyValuePair<string, string> kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
