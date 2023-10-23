using System;
using System.Collections.Generic;

namespace DragRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICar> cars = new List<ICar>
            {
                new Audi(),
                new Bmw(),
                new Lexus(),
                new Tesla(),
                new Mercedes(),
                new Porsche()
            };

            for (int i = 0; i < 10; i++)
            {
                foreach (var car in cars)
                {
                    car.SpeedUp();
                    if (i == 2 && car is IBoostable boostableCar)
                    {
                        boostableCar.UseNitrousOxideEngine();
                    }
                }
            }

            ICar fastestCar = GetFastestCar(cars);
            Console.WriteLine($"The fastest car is {fastestCar.GetType().Name} with a speed of {fastestCar.ShowCurrentSpeed()}.");
        }

        static ICar GetFastestCar(List<ICar> cars)
        {
            ICar fastestCar = null;
            int maxSpeed = 0;

            foreach (var car in cars)
            {
                int currentSpeed = int.Parse(car.ShowCurrentSpeed());
                if (currentSpeed > maxSpeed)
                {
                    maxSpeed = currentSpeed;
                    fastestCar = car;
                }
            }

            return fastestCar;
        }
    }
}
