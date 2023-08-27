using System;

namespace Animal
{
    public abstract class Food
    {
        public int Quantity { get; protected set; }

        public Food(int quantity)
        {
            Quantity = quantity;
        }
    }
}
