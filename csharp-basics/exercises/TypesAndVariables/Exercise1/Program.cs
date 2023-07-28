using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int Cars = 100;
            int Drivers = 28;
            int Passengers = 90;
            int CarsNotDriven;
            int CarsDriven;

            double SeatsInACar = 4.0;
            double CarpoolCapacity;
            double AveragePassengersPerCar;

            CarsNotDriven = Cars - Drivers;
            CarsDriven = Drivers;
            CarpoolCapacity = CarsDriven * SeatsInACar;
            AveragePassengersPerCar = Passengers / (double)CarsDriven;

            Console.WriteLine("There are " + Cars + " cars available.");
            Console.WriteLine("There are only " + Drivers + " drivers available.");
            Console.WriteLine("There will be " + CarsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + CarpoolCapacity.ToString("F2") + " people today.");
            Console.WriteLine("We have " + Passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + AveragePassengersPerCar.ToString("F2") + " in each car.");
            Console.ReadKey();
        }
    }
}
