using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
        int[] numbers2 = { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
        int[] numbers3 = { 91, -4, 80, -73, -28 };
        int[] numbers4 = { };

        Console.WriteLine(string.Join(", ", CountPosSumNeg(numbers1)));
        Console.WriteLine(string.Join(", ", CountPosSumNeg(numbers2)));
        Console.WriteLine(string.Join(", ", CountPosSumNeg(numbers3)));
        Console.WriteLine(string.Join(", ", CountPosSumNeg(numbers4)));
    }

    static int[] CountPosSumNeg(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            return new int[0];
        }

        int countPos = numbers.Count(num => num > 0);
        int sumNeg = (int)numbers.Where(num => num < 0).Sum();
        return new int[] { countPos, sumNeg };
    }
}