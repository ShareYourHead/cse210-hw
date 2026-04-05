using System;
using System.Collections.Generic;

namespace Foundation2
{
    public class Order(Customer customer)
    {
        private List<Product> _products = new List<Product>();
        private Customer _customer = customer;

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void AddProduct(string name, double price, int quantity)
        {
            _products.Add(new Product(name,price,quantity));
        }

        public string GetTotalCost()
        {
            double subtotal = 0;
            foreach (Product product in _products)
            {
                subtotal += product.GetTotalCost();
            }
            double shipping = _customer.InUSA() ? 5.00 : 35.00;
            double total = subtotal + shipping;
            return $"Subtotal: {subtotal:C2}\nShipping: {shipping:C2}\nTOTAL: {total:C2}";
        }

        public string GetPackingLabel()
        {
            string label = "";
            foreach (Product product in _products)
            {
                label += $"{product.GetQuantity()} {product.GetName()} - ID#{product.GetProductId()}\n";
            }
            return label.TrimEnd();
        }

        public string GetShippingLabel()
        {
            return $"{_customer.GetName()}\n{_customer.GetAddress()}";
        }
    }
}
