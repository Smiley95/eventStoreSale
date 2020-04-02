using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Infrastructure.Repositories;
using Sales.Domain.AggregateModel.SaleAggregate;

namespace Sales.API.Commands
{
    public class SaveSaleCommandHandler
    {
        private readonly EventRepository<Sale> _repository;

        public SaveSaleCommandHandler()
        {
            _repository = new EventRepository<Sale>();
        }

        public void Handle(SaveSaleCommand command)
        {
            _repository.Save(command.savedSale,DateTime.Now);
        }
    }
}
