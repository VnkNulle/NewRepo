using System;

namespace Exercise4
{
    class Program
    {
        private static bool ArrayContainsValue(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    return true;
            }
            return false;
        }

        private static void Main(string[] args)
        {
            int[] myArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };

            int targetValue = 1245;

            bool containsValue = ArrayContainsValue(myArray, targetValue);

            if (containsValue)
                Console.WriteLine("Contains!");
            else
                Console.WriteLine("Does not contain!");
        }
    }
}
