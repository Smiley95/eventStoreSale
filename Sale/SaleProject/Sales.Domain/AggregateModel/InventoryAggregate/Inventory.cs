using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.Domain.AggregateModel.InventoryAggregate
{
    class Inventory : AggregateRoot
    {
        private Guid id { get; }
        private List<Product> stockItems { get; set; }
    }
}
