using System;
using System.Linq;
using System.Collections.Generic;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = InitializeProducts();

            IVendingMachine vendingMachine = new VendingMachine(products);

            Console.WriteLine($"Manufacturer: {vendingMachine.Manufacturer}");
            Console.WriteLine($"Has Products: {vendingMachine.HasProducts}");
            Console.WriteLine($"Amount: {vendingMachine.Amount.Euros}.{vendingMachine.Amount.Cents}");
            Console.WriteLine($"Products:");

            foreach (var product in vendingMachine.Products)
            {
                Console.WriteLine($" - {product.Name}: {product.Price.Euros}.{product.Price.Cents} | Available: {product.Available}");
            }
        }

        static List<Product> InitializeProducts()
        {
            return new List<Product>
            {
                new Product { Name = "Soda", Price = new Money { Euros = 2, Cents = 50 }, Available = 10 },
                new Product { Name = "Chips", Price = new Money { Euros = 1, Cents = 20 }, Available = 5 },
                new Product { Name = "Coca-cola", Price = new Money { Euros = 2, Cents = 20 }, Available = 7 },
                new Product { Name = "Candy", Price = new Money { Euros = 0, Cents = 50 }, Available = 3 },
                new Product { Name = "Snickers", Price = new Money { Euros = 1, Cents = 35 }, Available = 10 },
                new Product { Name = "Mars", Price = new Money { Euros = 1, Cents = 15 }, Available = 13 },
            };
        }
    }
}
