using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using EventStore.ClientAPI;
using EventStore.ClientAPI.SystemData;

namespace eventTest.Store
{
    public class MyEventStore
    {
        private string _streamName;
        public IEventStoreConnection ConnectToEventStore()
        {
            var conn = EventStoreConnection.Create(new Uri("tcp://admin:changeit@127.0.0.1:1113"));
            conn.ConnectAsync().Wait();
            return conn;
        }
        public void SaveEvents(Sale sale, DateTime date)
        {
            _streamName = "MySalesStream";
            var eventType = "sold-product";
            var data = "{\"id\": \""+ sale.id+"\","+
                    "\"quantity\":"+ sale.Quantity+","+
                    "\"product\": {"+
                        "\"id\": \""+ sale.Product.id+"\","+
                        "\"name\": \"" + sale.Product.Name+"\","+
                        "\"price\":"+ sale.Product.Price + "},"+
                    "\"price\":" + sale.Price +
                "}";
            var metadata = "{"+date+"}";
            var eventPayload = new EventData(Guid.NewGuid(), eventType, true, Encoding.UTF8.GetBytes(data), Encoding.UTF8.GetBytes(metadata));
            ConnectToEventStore().AppendToStreamAsync(_streamName, ExpectedVersion.Any, eventPayload).Wait();
        }
        public IEnumerable<JObject> ReadAllEvents()
        {
            var readEvents = ConnectToEventStore().ReadStreamEventsForwardAsync(_streamName, StreamPosition.Start, 200, true);
            List<JObject> sales = new List<JObject>();
            foreach (var evt in readEvents.Result.Events)
            {
                JObject sale = JObject.Parse(Encoding.UTF8.GetString(evt.Event.Data));
                sales.Add(sale);
            }
            return sales;
        }
        public double GetTotalAmountOfSales()
        {
            List<JObject> sales = ReadAllEvents().ToList() ;
            double totalAmount = 0;
            foreach (var sale in sales)
            {
                totalAmount += (double) sale["price"];
            }
            return totalAmount;
        }
    }
}
