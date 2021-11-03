using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        static private Customer customer1 = new Customer { Name = "Nícolas", Id = 1};
        static private Customer customer2 = new Customer { Name = "Lucas", Id = 2 };
        private List<Customer> customers= new List<Customer> { customer1, customer2 };
        
        // GET: Customers
        public ActionResult Index()
        {
            var customersListViewModel = new CustomersListViewModel { customers = customers };

            return View(customersListViewModel);
        }

        public ActionResult Details(int id)
        {
            var specificCustomer= customers.Find(customer => customer.Id == id);
            return View(specificCustomer);
        }
    }
}