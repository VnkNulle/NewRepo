namespace Product1ToN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = production();
            Console.WriteLine("Product of numbers from 1 to 10 is: " + result);
        }

        static int production()
        {
            int product = 1;
            for (int i = 1; i <= 10; i++)
            {
                product *= i;
            }

            return product;
        }
    }
}
