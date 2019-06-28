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
            var movie = new List<Movie>
            {
                new Movie { Name = "Shrek", Id = 1 },
                new Movie { Name = "The Age of Adeline", Id = 2},
                new Movie { Name = "Test", Id = 3}
            };

            var viewModel = new MovieViewModel
            {
                Movie = movie
            };

            return View(viewModel);
        }

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}