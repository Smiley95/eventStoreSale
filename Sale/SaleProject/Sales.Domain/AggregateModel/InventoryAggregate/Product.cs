using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.Domain.AggregateModel.InventoryAggregate
{
    class Product
    {
        private Guid id { get; }
        private string label { get; set; }
        private double price { get; set; }
        private string category { get; set; }
        private string brand { get; set; }
        private int stocked { get; set; }

    }
}
