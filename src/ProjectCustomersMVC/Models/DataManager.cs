using ProjectCustomersMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCustomersMVC.Models
{
    public class DataManager
    {
        List<Customer> customers = new List<Customer>();
        //CustomerContext context;

        public void AddCustomer()
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "Sebastian";
            customer.Email = "sebbe_u@hotmail.com";

            var customer2 = new Customer();
            customer.Id = 2;
            customer.Name = "Linus";
            customer.Email = "lijoen@gmail.com";

            customers.Add(customer);
            customers.Add(customer2);
        }

        //public DataManager(CustomerContext context)
        //{
        //    this.context = context;
        //}
        public List<CustomerVM> ListCustomers()
        {
            AddCustomer();
            return customers
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
