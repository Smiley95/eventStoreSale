using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Domain.AggregateModel.SaleAggregate;

namespace Sales.API.Commands
{
    public class SaveSaleCommand
    {
        public readonly Sale savedSale;
        public SaveSaleCommand(Sale sale)
        {
            this.savedSale = sale;
        }
    }
}
