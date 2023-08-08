using System;

namespace Exercise2
{
    class Program
    {
        private static int SumValuesInRange(int min, int max)
        {
            int[] array = new int[max - min + 1];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = min + i;
                sum += array[i];
            }
            return sum;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());

            int sum = SumValuesInRange(minNumber, maxNumber);

            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
