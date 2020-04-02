using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eventTest
{
    public class Sale
    {
        public readonly Guid id;
        public int Quantity;
        public Product Product;
        public double Price;
        public Sale(int quantity, string productName, double price)
        {
            this.id = Guid.NewGuid();
            this.Quantity = quantity;
            this.Price = price;
            this.Product = new Product(productName,(price/quantity)); 

        }
    }
}
