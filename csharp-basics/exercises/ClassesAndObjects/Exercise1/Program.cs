using System;

public class Product
{
    private string name;
    private double price;
    private int amount;

    public Product(string name, double priceAtStart, int amountAtStart)
    {
        this.name = name;
        this.price = priceAtStart;
        this.amount = amountAtStart;
    }

    public void PrintProduct()
    {
        Console.WriteLine($"{name}, price {price:F2} EUR, amount {amount}");
    }

    public void ChangeQuantity(int newAmount)
    {
        amount = newAmount;
    }

    public void ChangePrice(double newPrice)
    {
        price = newPrice;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product mouse = new Product("Logitech mouse", 70.00, 14);
        Product iPhone = new Product("iPhone 5s", 999.99, 3);
        Product projector = new Product("Epson EB-U05", 440.46, 1);

        Console.WriteLine("Initial Product Information:");
        mouse.PrintProduct();
        iPhone.PrintProduct();
        projector.PrintProduct();

        mouse.ChangeQuantity(10);
        mouse.ChangePrice(60.00);

        iPhone.ChangeQuantity(1);
        iPhone.ChangePrice(900.99);

        Console.WriteLine("\nUpdated Product Information:");
        mouse.PrintProduct();
        iPhone.PrintProduct();
        projector.PrintProduct();
    }
}
