using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public static class CustomerManager
    {
        private static List<Customer> _customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "John Smith"},
            new Customer { Id = 2, Name = "Mary Williams"}
        };

        public static List<Customer> GetCustomers()
        {
            return _customers;
        }
    }
}