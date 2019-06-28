using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { id = 1, Name = "Jon Walsh"},
                new Customer { id = 2, Name = "James Walsh"},
                new Customer { id = 3, Name = "Mia Walsh"}
            };

            var viewResult = new CustomerViewModel
            {
                Customer = customers
            };

            return View(viewResult);
        }
    }
}