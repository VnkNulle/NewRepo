namespace Exercise1
{
    class Program
    {
        private static void SortNumericArray(int[] arr)
        {
            Array.Sort(arr);
        }

        private static void SortStringArray(string[] arr)
        {
            Array.Sort(arr);
        }

        private static void Main(string[] args)
        {
            int[] myArray1 =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2165, 1457, 2456
            };

            string[] myArray2 =
            {
                "Java",
                "Python",
                "PHP",
                "C#",
                "C Programming",
                "C++"
            };

            SortNumericArray(myArray1);

            Console.WriteLine("Original numeric array: " + string.Join(",", myArray1));
            Console.WriteLine("Sorted numeric array: " + string.Join(",", myArray1));

            SortStringArray(myArray2);

            Console.WriteLine("Original string array: " + string.Join(",", myArray2));
            Console.WriteLine("Sorted string array: " + string.Join(",", myArray2));

            Console.ReadKey();
        }
    }
}
