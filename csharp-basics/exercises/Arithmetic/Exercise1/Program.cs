namespace CheckInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number:");
            int num2 = int.Parse(Console.ReadLine());

            bool result = CheckCondition(num1, num2);
            Console.WriteLine($"Result: {result}");
        }

        static bool CheckCondition(int num1, int num2)
        {
            return num1 == 15 || num2 == 15 || num1 + num2 == 15 || Math.Abs(num1 - num2) == 15;
        }

    }
}
