namespace MoranNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Moran(132)); // Output: "H"
            Console.WriteLine(Moran(133)); // Output: "M"
            Console.WriteLine(Moran(134)); // Output: "Neither"
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        static string Moran(int number)
        {
            int sumOfDigits = SumOfDigits(number);

            if (number % sumOfDigits == 0)
            {
                if (IsPrime(number / sumOfDigits))
                    return "M";
                else
                    return "H";
            }
            else
            {
                return "Neither";
            }
        }
    }
}
