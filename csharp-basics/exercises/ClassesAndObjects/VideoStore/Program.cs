using System;

namespace VideoStore
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoStore store = new VideoStore();

            store.AddVideo("The Matrix");
            store.AddVideo("Godfather II");
            store.AddVideo("Star Wars Episode IV: A New Hope");

            store.RateVideo("The Matrix", 4);
            store.RateVideo("The Matrix", 5);
            store.RateVideo("Godfather II", 5);
            store.RateVideo("Godfather II", 4);
            store.RateVideo("Star Wars Episode IV: A New Hope", 5);

            store.RentVideo("The Matrix");
            store.RentVideo("Godfather II");
            store.RentVideo("Star Wars Episode IV: A New Hope");

            store.ListInventory();
        }
    }
}
