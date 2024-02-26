using CustomerMicroService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMicroService.Entities
{
    internal class CustomerCreated : CreateCustomer, IEvent
    {
        public string Guid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public CustomerCreated(string _guid)
        {
            this.Guid = _guid;
        }
    }

}
