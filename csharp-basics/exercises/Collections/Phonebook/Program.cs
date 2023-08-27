using System;
using System.Collections.Generic;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phoneDirectory = new SortedDictionary<string, string>();

            while (true)
            {
                Console.WriteLine("Phone Directory Menu:");
                Console.WriteLine("1. Add a phone number");
                Console.WriteLine("2. Get a phone number");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter number: ");
                        string number = Console.ReadLine();
                        phoneDirectory[name] = number;
                        Console.WriteLine("Phone number added.");
                        break;

                    case "2":
                        Console.Write("Enter name: ");
                        string searchName = Console.ReadLine();
                        if (phoneDirectory.TryGetValue(searchName, out string phoneNumber))
                        {
                            Console.WriteLine($"Phone number: {phoneNumber}");
                        }
                        else
                        {
                            Console.WriteLine("Name not found in directory.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Exiting the program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
