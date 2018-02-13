using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidley.Models;
using Vidley.ViewModels;

namespace Vidley.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new MovieModels { Name = "Tiger Zinda Hai" };
            //return View(movie);
            //return Content("Hello There!!");
            //return HttpNotFound();
            var Customers = new List<Customer>
            {
                new Customer{ Name="Manish"},
                new Customer{Name="Sarika"}
            };

            var viewModel = new RandomMovieViewModel { Movie = movie, Customers = Customers };
            //return RedirectToAction("Index", "Home", new { Page = 1, Sort = "Name" });
            return View(viewModel);
        }

        public ActionResult edit(int id)
        {
            return Content($"Id={id}");
        }

        public ActionResult Index(int? PageIndex,String SortBy)
        {
            if (!PageIndex.HasValue)
                PageIndex = 1;
            if (string.IsNullOrEmpty(SortBy))
                SortBy = "name";

            return Content($"Index={PageIndex} && SortBy={SortBy}");

        }
        [Route("Movie/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content($"{year}/{month}");
        }
        
    }
}