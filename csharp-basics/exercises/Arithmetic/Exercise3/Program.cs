namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerBound = 1;
            int upperBound = 100;

            int sum = 0;
            double average;

            for (int number = lowerBound; number <= upperBound; ++number)
            {
                sum += number;
            }

            average = (double)sum / (upperBound - lowerBound + 1);

            Console.WriteLine($"The sum of {lowerBound} to {upperBound} is {sum}");
            Console.WriteLine($"The average is {average:F1}");
        }
    }
}