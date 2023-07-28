using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, Eyes, Teeth, Hair;
            int Age;
            double HeightInInches, WeightInPounds;

            Name = "Zed A. Shaw";
            Age = 35;
            HeightInInches = 74;
            WeightInPounds = 180;
            Eyes = "Blue";
            Teeth = "White";
            Hair = "Brown";

            double HeightInCentimeters = HeightInInches * 2.54;
            double WeightInKilos = WeightInPounds * 0.453592;

            Console.WriteLine("Let's talk about " + Name + ".");
            Console.WriteLine("He's " + HeightInCentimeters.ToString("F2") + " centimeters tall.");
            Console.WriteLine("He's " + WeightInKilos.ToString("F2") + " kilograms heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + Eyes + " eyes and " + Hair + " hair.");
            Console.WriteLine("His teeth are usually " + Teeth + " depending on the coffee.");
            Console.WriteLine("If I add " + Age + ", " + HeightInInches + ", and " + WeightInPounds
                               + " I get " + (Age + HeightInInches + WeightInPounds) + ".");

            Console.ReadKey();
        }
    }
}
