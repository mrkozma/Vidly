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
        public ActionResult Index()
        {
            var movies = MovieManager.GetMovies();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            List<Movie> movies = MovieManager.GetMovies();
            Movie theMovie = movies.FirstOrDefault(m => m.Id == id);

            return View(theMovie);
        }

        public ActionResult Random()
        {
            Movie movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>()
            {
                new Customer() { Id = 1, Name = "Customer 1" },
                new Customer() { Id = 2, Name = "Customer 2" },
                new Customer() { Id = 3, Name = "Customer 3" },
                new Customer() { Id = 4, Name = "Customer 4" }
            };

            var viewModel = new RandomMovieViewModel() 
            {
                Customers = customers,
                Movie = movie
            };

            return View(viewModel);
        }
    }
}