using CustomerMicroService.Contracts;
using CustomerMicroService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMicroService.Services.Handler
{
    internal class CreateCustomerHandler : ICommandHandler<CreateCustomer>
    {
        public void Handle(CreateCustomer command)
        {
            Console.WriteLine(command.Name + " Inserted into DB Using EFCore");
             
            //Event Queue
        }
    }
}
