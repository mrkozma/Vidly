using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            CustomerManager custManager = new CustomerManager();
            var customers = custManager.GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            CustomerManager custManager = new CustomerManager();
            var customers = custManager.GetCustomers();
            Customer theCustomer = customers.SingleOrDefault(c => c.Id == id); 

            return View(theCustomer);
        }
    }
}