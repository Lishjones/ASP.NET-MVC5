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
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        //Customers/Details/Id
        public ActionResult Details(int Id)
        {
            var customers = GetCustomers();
            var customer = customers.SingleOrDefault<Customer>(x => x.Id == Id);
            
            if (customer == null)
                return new HttpNotFoundResult();

            return View(customer);
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Name = "John Doe", Id = 0},
                new Customer {Name = "Jane Doe", Id = 1}
            };
        }
    }
}