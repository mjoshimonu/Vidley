using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidley.Models;

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
            return RedirectToAction("Index", "Home", new { Page = 1, Sort = "Name" });
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

        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content($"{year}/{month}");
        }
        
    }
}