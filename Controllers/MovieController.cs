using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "The Dark Knight" };
            var customers = new List<Customer>
            {
                new Customer { Name="Customer 1"},
                new Customer { Name= "Customer 2"}
            };

            var viewModels = new RandomViewModel
            {
                Movie = movie,
                Customers = customers
        };

            return View(viewModels);
        }
        
        //GET: Movie
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        [Route("Movie/Details/{id}")]
        public ActionResult Details(int id)
        {

            var movie = GetMovies().SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();
            else
            {
                return View(movie);
            }


        }

        //GET : Movie/released

        [Route("Movie/released")]
        public ActionResult ReleasedByYear(int? year,int? month)
        {
            if (!year.HasValue)
                year = 2012;
            if (!month.HasValue)
                month = 1;
            return Content($"Year: {year} Month: {month}");
        }

        private List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id=1, Name="The Dark Knight" },
                new Movie { Id=2,Name="The Hater"}
            };
        }
    }
}