using System;

namespace Animal
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Squeak");
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
            {
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} are not eating that type of food!");
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", {LivingRegion}, {FoodEaten}]";
        }
    }
}
