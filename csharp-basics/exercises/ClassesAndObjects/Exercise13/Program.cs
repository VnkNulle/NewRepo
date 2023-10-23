using System;
using System.Collections.Generic;
using System.Linq;

class Smoothie
{
    private Dictionary<string, decimal> ingredientPrices = new Dictionary<string, decimal>
    {
        { "Strawberries", 1.50m },
        { "Banana", 0.50m },
        { "Mango", 2.50m },
        { "Blueberries", 1.00m },
        { "Raspberries", 1.00m },
        { "Apple", 1.75m },
        { "Pineapple", 3.50m }
    };

    public List<string> Ingredients { get; }

    public Smoothie(string[] ingredients)
    {
        Ingredients = ingredients.ToList();
    }

    public string GetCost()
    {
        decimal totalCost = Ingredients.Sum(ingredient => ingredientPrices.GetValueOrDefault(ingredient, 0));
        return $"£{totalCost:0.00}";
    }

    public string GetPrice()
    {
        decimal cost = Ingredients.Sum(ingredient => ingredientPrices.GetValueOrDefault(ingredient, 0));
        decimal price = cost + cost * 1.5m;
        return $"£{price:0.00}";
    }

    public string GetName()
    {
        List<string> ingredientNames = new List<string>();
        foreach (string ingredient in Ingredients)
        {
            if (ingredient.EndsWith("berries"))
            {
                ingredientNames.Add(ingredient.Substring(0, ingredient.Length - 3) + "berry");
            }
            else
            {
                ingredientNames.Add(ingredient);
            }
        }

        ingredientNames.Sort();
        string name = string.Join(" ", ingredientNames);
        if (Ingredients.Count > 1)
        {
            name += " Fusion";
        }
        else
        {
            name += " Smoothie";
        }

        return name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Smoothie s1 = new Smoothie(new string[] { "Banana" });
        Console.WriteLine(string.Join(", ", s1.Ingredients));
        Console.WriteLine(s1.GetCost());
        Console.WriteLine(s1.GetPrice());
        Console.WriteLine(s1.GetName());

        Smoothie s2 = new Smoothie(new string[] { "Raspberries", "Strawberries", "Blueberries" });
        Console.WriteLine(string.Join(", ", s2.Ingredients));
        Console.WriteLine(s2.GetCost());
        Console.WriteLine(s2.GetPrice());
        Console.WriteLine(s2.GetName());
    }
}
