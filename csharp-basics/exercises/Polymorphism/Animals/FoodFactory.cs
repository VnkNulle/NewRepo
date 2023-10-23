using System;

namespace Animal
{
    public static class FoodFactory
    {
        public static Food CreateFood(string foodType, int quantity)
        {
            switch (foodType)
            {
                case "Vegetable":
                    return new Vegetable(quantity);
                case "Meat":
                    return new Meat(quantity);
                default:
                    throw new ArgumentException("Invalid food type");
            }
        }
    }
}
