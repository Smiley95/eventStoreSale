using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.API.Commands
{
    public class CancelSaleCommand
    {
        public readonly Guid canceledSaleId; 
        public CancelSaleCommand(Guid id)
        {
            this.canceledSaleId = id;
        }
    }
}
