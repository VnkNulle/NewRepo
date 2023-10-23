namespace VendingMachine
{
    public static class ProductManagement
    {
        public static bool AddProduct(IVendingMachine vendingMachine, string name, Money price, int count)
        {
            var product = new Product
            {
                Name = name,
                Price = price,
                Available = count
            };

            if (vendingMachine.Products.Contains(product))
                return false;

            vendingMachine.Products.Add(product);

            return true;
        }

        public static bool UpdateProduct(IVendingMachine vendingMachine, int productNumber, string name, Money? price, int amount)
        {
            if (productNumber >= 0 && productNumber < vendingMachine.Products.Count)
            {
                var product = vendingMachine.Products[productNumber];
                product.Name = name;

                if (price.HasValue)
                    product.Price = price.Value;

                product.Available = amount;
                vendingMachine.Products[productNumber] = product;
                return true;
            }

            return false;
        }
    }
}
