using ProjectCustomersMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCustomersMVC.Models
{
    public class DataManager
    {
        CustomerContext context;

        public DataManager(CustomerContext context)
        {
            this.context = context;
        }
        public List<CustomerVM> ListCustomers()
        {
            return context.Customers
                .OrderBy(o => o.Name)
                .Select(o => new CustomerVM
                {
                    Name = o.Name,
                    Email = o.Email
                })
                .ToList();
        }
    }
}
