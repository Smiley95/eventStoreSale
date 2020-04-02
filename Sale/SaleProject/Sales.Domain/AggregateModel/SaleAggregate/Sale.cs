using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.Domain.AggregateModel.SaleAggregate
{
    public class Sale : AggregateRoot
    {
        public readonly Guid id;
        private DateTime date { get; set; }
        private int quantity { get; set; }
        private double amount { get; set; }
        private Product soldProduct { get; set; }
    }
}
