using System;

namespace Animal
{
    public abstract class Animal
    {
        public string Name { get; protected set; }
        public double Weight { get; protected set; }

        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public abstract void MakeSound();
        public abstract void Eat(Food food);

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}]";
        }
    }
}
