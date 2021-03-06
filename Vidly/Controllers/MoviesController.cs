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
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name= "Shrek" };
            var customers = new List<Customer>
             {
                 new Customer{Name = "Customer 1"},
                 new Customer{Name = "Customer 2"}
             };

            var viewModel = new RandomMovieViewModel { Movie = movie, Customers = customers };

            return View(viewModel);
        }

        public ActionResult Edit (int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index()
        {
            var movie = new Movie { Name = "Shrek" };
            var movie2 = new Movie { Name = "Spiderman" };
            var movies = new List<Movie>
            {
                movie, movie2
            };


            var moviesViewModel = new MoviesListViewModel { movies = movies };

            return View(moviesViewModel);

        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}