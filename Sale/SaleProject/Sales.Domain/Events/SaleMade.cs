using System;
using System.Collections.Generic;
using System.Text;
using Sales.Domain.AggregateModel.SaleAggregate;

namespace Sales.Domain.Events
{
    class SaleMade : IEvent
    {
        public readonly Guid id;
        public readonly Sale sale;
        public SaleMade (Guid id)
        {
            this.id = id;
        }
    }
}
