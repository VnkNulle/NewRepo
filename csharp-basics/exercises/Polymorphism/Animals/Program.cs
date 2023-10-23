using System;

namespace Animal
{
    class Program
    {
        private static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] animalInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string[] foodInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Animal animal = AnimalFactory.CreateAnimal(animalInfo[0], animalInfo);
                Food food = FoodFactory.CreateFood(foodInfo[0], int.Parse(foodInfo[1]));

                animal.MakeSound();
                animal.Eat(food);

                Console.WriteLine(animal);
            }
        }
    }
