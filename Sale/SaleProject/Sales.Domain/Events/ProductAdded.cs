using System;
using System.Collections.Generic;
using System.Text;
using Sales.Domain.AggregateModel.InventoryAggregate;

namespace Sales.Domain.Events
{
    class ProductAdded : IEvent
    {
        public readonly Guid id;
        public Product addedItem;
        public ProductAdded(Guid id, Product newItem)
        {
            this.id = id;
            addedItem = newItem;
        }
    }
}
