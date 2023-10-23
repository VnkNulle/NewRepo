using System;

namespace Animal
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; private set; }
        public int FoodEaten { get; protected set; }

        public Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            LivingRegion = livingRegion;
        }
    }
}
