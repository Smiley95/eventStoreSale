using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.Domain.Events
{
    class ProductRemoved: IEvent
    {
        public readonly Guid id;
        public readonly Guid productId;
        public ProductRemoved(Guid id, Guid productId)
        {
            this.id = id;
            this.productId = productId;
        }
    }
}
