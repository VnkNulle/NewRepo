namespace BMICalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the BMI Calculator!");
            Console.WriteLine("");
            Console.Write("Enter your weight in kilograms: ");
            double weightKg = double.Parse(Console.ReadLine());

            Console.Write("Enter your height in meters: ");
            double heightMeters = double.Parse(Console.ReadLine());

            double bmi = CalculateBMI(weightKg, heightMeters);
            Console.WriteLine($"Your BMI is: {bmi:F2}");

            if (bmi >= 18.5 && bmi <= 25)
            {
                Console.WriteLine("You have an optimal weight. Keep up the good work!");
            }
            else if (bmi < 18.5)
            {
                Console.WriteLine("You are underweight. Consider consulting a doctor or a dietitian.");
            }
            else
            {
                Console.WriteLine("You are overweight. Consider adopting a healthier lifestyle.");
            }
        }

        static double CalculateBMI(double weightKg, double heightMeters)
        {
            return weightKg / (heightMeters * heightMeters);
        }
    }
}
