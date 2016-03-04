using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ProjectCustomersMVC.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectCustomersMVC.Controllers
{
    public class CustomersController : Controller
    {
        //DataManager datamanager;
        //CustomerContext context;
        //public CustomersController(CustomerContext context)
        //{
        //    this.context = context;
        //    datamanager = new DataManager(context);
        //}
        // GET: /<controller>/
        public IActionResult Index()
        {
            var dataManager = new DataManager();
            var model = dataManager.ListCustomers();
            return View(model);
        }
    }
}
