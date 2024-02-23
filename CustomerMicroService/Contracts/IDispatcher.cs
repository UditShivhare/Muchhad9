using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMicroService.Contracts
{
    internal interface IDispatcher
    {
        void Send<T>(T command) where T : ICommands;
    }
}
