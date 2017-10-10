using Photerva.Lib.Models;
using Photerva.Lib.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Photerva.Lib.Extensions
{
    public static class CustomerExtensions
    {
        public static CustomerViewModel ToViewModel(this Customer customer)
        {
            return new CustomerViewModel
            {
                CustomerID = customer.CustomerID,
                DateAdded = customer.DateAdded,
                DateUpdated = customer.DateUpdated,
                Deleted = customer.Deleted,
                Name = customer.Name,
                Notes = customer.Notes
            };
        }

        public static List<CustomerViewModel> ToViewModel(this List<Customer> customers)
        {
            var list = new List<CustomerViewModel>();
            customers.ForEach(x => list.Add(x.ToViewModel()));
            return list;
        }
    }
}
