using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CustomerMicroService.Entities
{
    internal class CreateCustomer :Customer, Contracts.ICommands
    {
        public DateTime CreatedDate { get; set; }

       // public event EventHandler? CanExecuteChanged;

        


        // public string Guid { get; set; }

        //public event EventHandler? CanExecuteChanged;

        //public bool CanExecute(object? parameter)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Execute(object? parameter)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
