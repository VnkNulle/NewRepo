using System;
using System.Collections.Generic;
using System.IO;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../FlightPlanner/flights.txt";

        static void Main(string[] args)
        {
            Dictionary<string, List<string>> flightData = LoadFlightData();

            Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display the list of cities press 1");
            Console.WriteLine("To exit the program press #");

            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                DisplayCities(flightData);
                Console.WriteLine("To select a city from which you would like to start press 1");
                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.Write("Enter the starting city: ");
                    string startCity = Console.ReadLine();

                    List<string> route = PlanFlightRoute(flightData, startCity);
                    Console.WriteLine("Your round-trip flight route:");
                    Console.WriteLine(string.Join(" -> ", route));
                }
            }
        }

        static Dictionary<string, List<string>> LoadFlightData()
        {
            Dictionary<string, List<string>> flightData = new Dictionary<string, List<string>>();

            try
            {
                string[] lines = File.ReadAllLines(Path);

                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] cities = line.Split("->", StringSplitOptions.RemoveEmptyEntries);
                        string fromCity = cities[0].Trim();
                        string toCity = cities[1].Trim();

                        if (!flightData.ContainsKey(fromCity))
                        {
                            flightData[fromCity] = new List<string>();
                        }

                        flightData[fromCity].Add(toCity);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading flight data: {ex.Message}");
            }

            return flightData;
        }

        static void DisplayCities(Dictionary<string, List<string>> flightData)
        {
            Console.WriteLine("List of cities:");
            foreach (var city in flightData.Keys)
            {
                Console.WriteLine(city);
            }
        }

        static List<string> PlanFlightRoute(Dictionary<string, List<string>> flightData, string startCity)
        {
            List<string> route = new List<string>();
            string currentCity = startCity;

            while (true)
            {
                route.Add(currentCity);

                Console.WriteLine($"From {currentCity}, you can directly fly to:");
                foreach (var destination in flightData[currentCity])
                {
                    Console.WriteLine(destination);
                }

                Console.Write("Where would you like to fly to? (or press # to finish): ");
                string userInput = Console.ReadLine();

                if (userInput == "#")
                {
                    if (currentCity == startCity)
                    {
                        route.Add(startCity);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You need to select a destination to complete the round-trip.");
                    }
                }
                else if (flightData.ContainsKey(currentCity) && flightData[currentCity].Contains(userInput))
                {
                    currentCity = userInput;
                }
                else
                {
                    Console.WriteLine("Invalid destination. Please select from the available options.");
                }
            }

            return route;
        }
    }
}
