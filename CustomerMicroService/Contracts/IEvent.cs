using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMicroService.Contracts
{
    //ICommandHandler<CreateCustomer> ---- It is use for Same MicroService
    //IEventHandler<CustomerCreated>   -----EventHandler Means you push to other
    public interface IEvent
    {
        public string Guid { get; set; }
    }
}
