using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Vidly.Models
{
    public class CustomerManager
    {
        private ApplicationDbContext _context;

        public CustomerManager()
        {
            _context = new ApplicationDbContext();

        }


        //public List<Customer> GetCustomers()
        //{
        //    return _context.Customers.ToList();
        //}

        public List<Customer> GetCustomers()
        {
            return _context.Customers.Include("MembershipType").ToList();
        }
    }
}