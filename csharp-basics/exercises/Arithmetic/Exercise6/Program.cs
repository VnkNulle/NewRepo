namespace CozaLozaWoza
{
    class Program
    {
        static void Main()
        {
            PrintNumbersWithRules();
        }

        static void PrintNumbersWithRules()
        {
            for (int i = 1; i <= 110; i++)
            {
                string output = "";

                if (i % 3 == 0)
                {
                    output += "Coza";
                }

                if (i % 5 == 0)
                {
                    output += "Loza";
                }

                if (i % 7 == 0)
                {
                    output += "Woza";
                }

                if (output == "")
                {
                    output = i.ToString();
                }

                Console.Write(output + " ");

                if (i % 11 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
