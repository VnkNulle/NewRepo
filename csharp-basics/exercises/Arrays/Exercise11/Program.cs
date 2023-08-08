using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(FindNemo("I am finding Nemo !"));
        Console.WriteLine(FindNemo("Nemo is me"));
        Console.WriteLine(FindNemo("I Nemo am"));
        Console.WriteLine(FindNemo("I can't find Nemo :("));
    }

    static string FindNemo(string sentence)
    {
        string[] words = sentence.Split(new char[] { ' ', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Equals("Nemo", StringComparison.OrdinalIgnoreCase))
            {
                return $"I found Nemo at {i + 1}!";
            }
        }
        return "I can't find Nemo :(";
    }
}
