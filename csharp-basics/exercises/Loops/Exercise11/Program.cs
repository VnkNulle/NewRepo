using System;

class Program
{
    static string ReverseCase(string input)
    {
        char[] reversed = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
            if (char.IsLower(currentChar))
            {
                reversed[i] = char.ToUpper(currentChar);
            }
            else if (char.IsUpper(currentChar))
            {
                reversed[i] = char.ToLower(currentChar);
            }
            else
            {
                reversed[i] = currentChar;
            }
        }

        return new string(reversed);
    }

    static void Main(string[] args)
    {
        Console.WriteLine(ReverseCase("Happy Birthday"));
        Console.WriteLine(ReverseCase("MANY THANKS"));
        Console.WriteLine(ReverseCase("sPoNtAnEoUs"));
    }
}
