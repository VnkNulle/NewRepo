namespace CheckOddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number:");
            int number = int.Parse(Console.ReadLine());

            if (isOdd(number)) 
            {
                Console.WriteLine("Odd number");
            }

            else
            {
                Console.WriteLine("Even number");
            }

            Console.WriteLine("bye!");

        }

        static bool isOdd(int number)
        {
            return number % 2 != 0;
        }

    }
}