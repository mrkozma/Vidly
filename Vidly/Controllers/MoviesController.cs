using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movie movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>()
            {
                new Customer() {Id = 1, Name = "Customer 1"},
                new Customer() {Id = 2, Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel() 
            {
                Customers = customers,
                Movie = movie
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("The id is: " + id);
        }

        public ActionResult Index(int pageIndex = 1, string sortBy = "name")
        {
            return Content($"PageIndex: {pageIndex} and sortBy: {sortBy}");
        }

        [Route(template: @"movies/released/{year:regex(\d{4})}/{month:regex(\d{2}):range(1, 12)}")] //compare to custom routeconfig, MoviesByReleseDate
        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content($"Year is: {year} and month is: {month}");
        }
    }
}