namespace CalculateArea
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();

            int targetNumber = random.Next(1, 101);

            Console.WriteLine("I'm thinking of a number between 1 and 100. Try to guess it.");

            int attempts = 0;

            while (true)
            {
                int guess = int.Parse(Console.ReadLine());

                attempts++;

                if (guess == targetNumber)
                {
                    Console.WriteLine("You guessed it! What are the odds?!?");
                    break;
                }
                else if (guess < targetNumber)
                {
                    Console.WriteLine("Sorry, you are too low. I was thinking of " + targetNumber + ".");
                }
                else
                {
                    Console.WriteLine("Sorry, you are too high. I was thinking of " + targetNumber + ".");
                }
            }

            Console.WriteLine("You made " + attempts + " attempt(s).");
        }
    }
}
