using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.Domain.Events
{
    class InventoryCreated : IEvent
    {
        public readonly Guid id;
        public DateTime date;
        public InventoryCreated (Guid id)
        {
            this.id = id;
            date = DateTime.Now;
        }
    }
}
