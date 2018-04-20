using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootData.Models;
using BootData.Models.MovieViewModel;

namespace BootData.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Harry Potter" };
            var customer = new List<Customer>
            {
               new Customer {Name="Kishoew",Id=1 },
               new Customer {Name="aman",Id=2 },
               new Customer {Name="jeff",Id=3 },
               new Customer {Name="mark",Id=4 }
            };

            var viewModel = new RandomViewModel
            {
                Movie = movie,
                Customer = customer
            };
            return View(viewModel);
        }
    }
}