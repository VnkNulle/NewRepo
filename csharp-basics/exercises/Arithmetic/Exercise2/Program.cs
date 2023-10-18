namespace OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number:");
            int number = int.Parse(Console.ReadLine());

            if (IsOdd(number)) 
            {
                Console.WriteLine("Odd number");
            }
            else
            {
                Console.WriteLine("Even number");
            }

            Console.WriteLine("bye!");

        }

        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }
}
