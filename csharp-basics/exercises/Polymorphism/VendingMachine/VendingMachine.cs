using System;
using System.Linq;
using System.Collections.Generic;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        private readonly List<Product> _products;
        private Money _amount;

        public VendingMachine(List<Product> products)
        {
            _products = products;
            _amount = new Money();
        }

        public string Manufacturer => "VendingMachine Inc.";
        public bool HasProducts => _products.Any(product => product.Available > 0);
        public Money Amount => _amount;
        public List<Product> Products => _products;

        public Money InsertCoin(Money amount)
        {
            return MoneyManagement.InsertCoin(amount, ref _amount);
        }

        public Money ReturnMoney()
        {
            return MoneyManagement.ReturnMoney(ref _amount);
        }

        public bool AddProduct(string name, Money price, int count)
        {
            return ProductManagement.AddProduct(this, name, price, count);
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            return ProductManagement.UpdateProduct(this, productNumber, name, price, amount);
        }
    }
}
