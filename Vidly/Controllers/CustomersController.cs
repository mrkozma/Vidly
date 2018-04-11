using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            List<Customer> customers = CustomerManager.GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            List<Customer> customers = CustomerManager.GetCustomers();
            Customer theCustomer = customers.FirstOrDefault(c => c.Id == id); 

            return View(theCustomer);
        }
    }
}