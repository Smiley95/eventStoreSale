using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eventTest
{
    public class Product
    {
        public readonly Guid id;
        public string Name;
        public double Price;
        public Product(string name, double price)
        {
            this.id = Guid.NewGuid();
            this.Price = price;
            this.Name = name;
        }
    }
}
