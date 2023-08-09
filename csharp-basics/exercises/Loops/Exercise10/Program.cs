using System;

namespace NumberSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter min value: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Enter max value: ");
            int max = int.Parse(Console.ReadLine());

            for (int i = 0; i <= max - min; i++)
            {
                for (int j = 0; j <= max - min; j++)
                {
                    int num = (min + i + j) % (max - min + 1) + min;
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }
    }
}
