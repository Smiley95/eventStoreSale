using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.Domain.AggregateModel.SaleAggregate
{
    class Product
    {
        public readonly Guid id; 
        private string label { get; set; }
        private double price { get; set; }
    }
}
