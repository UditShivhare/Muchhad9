using CustomerMicroService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMicroService.Services.Dispatcher
{
    internal class CustomerDispatcher : IDispatcher
    {
        public void Send<T>(T command) where T : ICommands
        {
           //Mapping customer handler
        }
    }
}
