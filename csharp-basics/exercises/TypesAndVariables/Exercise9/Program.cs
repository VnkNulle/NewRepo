using System;

namespace SpeedConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            const double MetersToKilometers = 0.001;
            const double MetersToMiles = 0.000621371;

            Console.Write("Input distance in meters: ");
            double distanceInMeters = double.Parse(Console.ReadLine());

            Console.Write("Input hours: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Input minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            Console.Write("Input seconds: ");
            int seconds = int.Parse(Console.ReadLine());

            // Convert to seconds
            int totalTimeInSeconds = hours * 3600 + minutes * 60 + seconds;

            //Meters per second
            double speedInMetersPerSecond = distanceInMeters / totalTimeInSeconds;

            //Kilometers per hour
            double speedInKilometersPerHour = (distanceInMeters * MetersToKilometers) / (totalTimeInSeconds / 3600.0);

            //Miles per hour
            double speedInMilesPerHour = (distanceInMeters * MetersToMiles) / (totalTimeInSeconds / 3600.0);

            Console.WriteLine($"Your speed in meters/second is {speedInMetersPerSecond}");
            Console.WriteLine($"Your speed in km/h is {speedInKilometersPerHour}");
            Console.WriteLine($"Your speed in miles/h is {speedInMilesPerHour}");
        }
    }
}
