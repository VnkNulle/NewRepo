using System;

namespace FuelConsumptionCalculator
{
    class Car
    {
        private double startKilometers;
        private double endKilometers;
        private double liters;

        public Car(double startOdo, double endingOdo, double liters)
        {
            startKilometers = startOdo;
            endKilometers = endingOdo;
            this.liters = liters;
        }

        public double CalculateConsumption()
        {
            return (liters / (endKilometers - startKilometers)) * 100.0;
        }

        public bool IsGasHog()
        {
            return CalculateConsumption() > 15.0;
        }

        public bool IsEconomyCar()
        {
            return CalculateConsumption() < 5.0;
        }

        public void FillUp(int mileage, double liters)
        {
            startKilometers = endKilometers;
            endKilometers = mileage;
            this.liters += liters;
        }
    }

    class Program
    {
        private static void Main(string[] args)
        {
            Car car1 = new Car(10000, 10500, 50);
            Car car2 = new Car(8000, 8055, 48);

            Console.WriteLine("Car 1 Fuel Consumption: " + car1.CalculateConsumption() + " l/100km");
            Console.WriteLine("Car 2 Fuel Consumption: " + car2.CalculateConsumption() + " l/100km");

            car1.FillUp(10800, 30);
            car2.FillUp(8125, 25);

            Console.WriteLine("\nAfter refueling:");

            Console.WriteLine("Car 1 Fuel Consumption: " + car1.CalculateConsumption() + " l/100km");
            Console.WriteLine("Car 2 Fuel Consumption: " + car2.CalculateConsumption() + " l/100km");

            Console.WriteLine("\nCar 1 is a gas hog: " + car1.IsGasHog());
            Console.WriteLine("Car 2 is an economy car: " + car2.IsEconomyCar());
        }
    }
}
