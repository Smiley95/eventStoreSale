using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Domain.AggregateModel.SaleAggregate;
using Sales.Infrastructure.Repositories;

namespace Sales.API.Commands
{
    public class CancelSaleCommandHandler
    {
        private readonly EventRepository<Sale> _repository;

        public CancelSaleCommandHandler()
        {
            _repository = new EventRepository<Sale>();
        }

        public void Handle(CancelSaleCommand command)
        {

            _repository.Save(_repository.GetById(command.canceledSaleId), DateTime.Now);
        }
    }
}
