using System;

namespace Exercise5
{
    class Program
    {
        private static int FindIndex(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    return i;
                }
            }
            return -1;
        }

        private static void Main(string[] args)
        {
            int[] myArray = { 25, 14, 56, 15, 36, 56, 77, 18, 29, 49 };

            var indexElement1 = FindIndex(myArray, 36);
            var indexElement2 = FindIndex(myArray, 29);

            Console.WriteLine("Index position of 36 is: " + indexElement1);
            Console.WriteLine("Index position of 29 is: " + indexElement2);
        }
    }
}
