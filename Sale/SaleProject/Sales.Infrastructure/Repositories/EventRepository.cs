using System;
using System.Collections.Generic;
using System.Text;
using Sales.Domain.IRepositories;
using Sales.Domain.AggregateModel;
using Sales.Domain.AggregateModel.SaleAggregate;
using EventStore.ClientAPI;
using Sales.Infrastructure.eventStore;

namespace Sales.Infrastructure.Repositories
{
    public class EventRepository<T> : IRepository<T> where T : AggregateRoot, new() //shortcut you can do as you see fit with new()
    {
        private readonly IEventStoreConnection _storage;

        public EventRepository()
        {
            _storage = MyEventStore.EventStoreConnect();
        }

        public void Save(Sale sale, DateTime date)
        {
            var streamName = "Sales";
            var eventType = "sale added";
            var data = "{ \"date\":\"" + date + "\"," +
                "{ \"sale id\":\"" + sale.id + "\"," +
                "\"sale details\":\"" + sale.ToString() + "\",}";
            var metadata = "{}";
            var eventPayload = new EventData(Guid.NewGuid(), eventType, true, Encoding.UTF8.GetBytes(data), Encoding.UTF8.GetBytes(metadata));
            _storage.AppendToStreamAsync(streamName, ExpectedVersion.Any, eventPayload).Wait();
        }

        public T GetById(Guid id)
        {
            var obj = new T();
            var e = _storage.ReadStreamEventsForwardAsync("Sales", 0, 1, false).Result;
            return obj;
        }
    }
}
