using System;
using System.Collections.Generic;
using System.Text;
using Sales.Domain.AggregateModel.InventoryAggregate;

namespace Sales.Domain.Events
{
    class ProductUpdated : IEvent
    {
        public readonly Guid id;
        public readonly Guid productId;
        public readonly Product updatedProduct;
        public ProductUpdated(Guid id, Guid productId, Product product)
        {
            this.id = id;
            this.productId = productId;
            updatedProduct = product; 
        }
    }
}
