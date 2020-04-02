using System;
using System.Collections.Generic;
using System.Text;
using EventStore.ClientAPI;
using EventStore.ClientAPI.SystemData;

namespace Sales.Infrastructure.eventStore
{
    class MyEventStore
    {
        public static IEventStoreConnection EventStoreConnect()
        {
            var conn = EventStoreConnection.Create(new Uri("tcp://admin:changeit@localhost:1113"));
            conn.ConnectAsync().Wait();
            return conn;
        }
    }
}