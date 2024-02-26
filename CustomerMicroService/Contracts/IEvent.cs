using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMicroService.Contracts
{
    public interface IEvent
    {
        public string Guid { get; set; }
    }
}
