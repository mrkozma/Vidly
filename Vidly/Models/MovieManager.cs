using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public static class MovieManager
    {
        private static List<Movie> _movies = new List<Movie>
        {
            new Movie { Name = "Shrek", Id = 1 },
            new Movie { Name = "Wall-e", Id = 2 }
        };

        public static List<Movie> GetMovies()
        {
            return _movies;
        }
    }
}