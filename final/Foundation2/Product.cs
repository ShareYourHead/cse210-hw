using System;

namespace Foundation2
{
    public class Product(string name, double price, int quantity)
    {
        private string _name = name;
        private int _productId = Random.Shared.Next(1000000, 10000000);
        private double _pricePerUnit = price;
        private int _quantity = quantity;

        public double GetTotalCost()
        {
            return _pricePerUnit * _quantity;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetProductId()
        {
            return _productId;
        }

        public int GetQuantity()
        {
            return _quantity;
        }
    }
}
