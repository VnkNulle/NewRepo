using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Test cases
        string[] names1 = { "mavis", "senaida", "letty" };
        string[] names2 = { "samuel", "MABELLE", "letitia", "meridith" };
        string[] names3 = { "Slyvia", "Kristal", "Sharilyn", "Calista" };

        Console.WriteLine(string.Join(", ", CapMe(names1)));
        Console.WriteLine(string.Join(", ", CapMe(names2)));
        Console.WriteLine(string.Join(", ", CapMe(names3)));
    }

    static string[] CapMe(string[] names)
    {
        return names.Select(name => char.ToUpper(name[0]) + name.Substring(1).ToLower()).ToArray();
    }
}
