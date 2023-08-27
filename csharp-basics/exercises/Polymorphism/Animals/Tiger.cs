using System;

namespace Animal
{
    public class Tiger : Felime
    {
        public Tiger(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAR!!!");
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
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
            return base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}