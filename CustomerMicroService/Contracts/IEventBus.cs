using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMicroService.Contracts
{
    internal interface IEventBus
    {
        void Publish<T>(Guid guid, T @event) where T:IEvent;
        List<IEvent> GetEvent(Guid aggregateId);
        List<IEvent> GetEvents();
    }
}
