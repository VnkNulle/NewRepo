using System;

namespace Animal
{
    public class Cat : Felime
    {
        public string Breed { get; private set; }

        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion)
        {
            Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public override void Eat(Food food)
        {
            FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return base.ToString() + $"{Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
