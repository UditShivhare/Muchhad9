using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMicroService.Contracts
{
    public interface ICommandHandler<T> where T : ICommands
    {
        void Handle(T command);
    }
}
