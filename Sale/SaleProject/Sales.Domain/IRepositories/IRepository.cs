using System;
using System.Collections.Generic;
using System.Text;
using Sales.Domain.AggregateModel;

namespace Sales.Domain.IRepositories
{
    public interface IRepository<T> where T : AggregateRoot, new()
    {
        T GetById(Guid id);
    }
}
