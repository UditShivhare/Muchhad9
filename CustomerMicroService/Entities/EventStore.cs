using CustomerMicroService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMicroService.Entities
{
    internal class EventStore : IEventStore
    {
        private readonly Dictionary<Guid, List<Contracts.IEvent>> _eventStore = new Dictionary<Guid, List<Contracts.IEvent>>();

        public List<IEvent> GetEvents(Guid aggregateId)
        {
            return _eventStore[aggregateId];
        }

        public List<IEvent> GetEvents()
        {
            return _eventStore.SelectMany(d=>d.Value).ToList();
        }

        public void SaveEvents(Guid aggregateId,IEvent e)
        {
            List<IEvent> events = null;
            if (!_eventStore.ContainsKey(aggregateId))
            {
                events = new List<IEvent>();
                _eventStore.Add(aggregateId, events);
            }
            else
            {
                events = _eventStore[aggregateId];
            }
            events.Add(e);
        }
    }
}
