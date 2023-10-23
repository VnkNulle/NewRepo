using System;

class FuelGauge
{
    private int currentFuel;

    public FuelGauge()
    {
        currentFuel = 0;
    }

    public int GetCurrentFuel()
    {
        return currentFuel;
    }

    public void ReFuel()
    {
        if (currentFuel < 70)
            currentFuel++;
    }

    public void ConsumeFuel()
    {
        if (currentFuel > 0)
            currentFuel--;
    }
}

class Odometer
{
    private int currentMileage;
    private FuelGauge fuelGauge;

    public Odometer(FuelGauge fuelGauge)
    {
        currentMileage = 0;
        this.fuelGauge = fuelGauge;
    }

    public int GetCurrentMileage()
    {
        return currentMileage;
    }

    public void Mileage()
    {
        if (currentMileage < 999999)
        {
            currentMileage++;
            if (currentMileage % 10 == 0)
                fuelGauge.ConsumeFuel();
        }
        else
        {
            currentMileage = 0;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        FuelGauge fuelGauge = new FuelGauge();
        Odometer odometer = new Odometer(fuelGauge);

        while (fuelGauge.GetCurrentFuel() < 70)
        {
            fuelGauge.ReFuel();
        }

        Console.WriteLine("Car filled up with fuel.");

        while (fuelGauge.GetCurrentFuel() > 0)
        {
            Console.WriteLine($"Mileage: {odometer.GetCurrentMileage()} km | Fuel: {fuelGauge.GetCurrentFuel()} liters");
            odometer.Mileage();
        }

        Console.WriteLine("Car ran out of fuel.");
    }
}
