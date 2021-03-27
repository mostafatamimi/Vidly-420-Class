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
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer> {
                new Customer{ Name = "Ahmad", Id = 2 },
                new Customer {Name = "Ali", Id=3}
            };

            var model = new RandomMoviesViewModel
            {
                Movie = movie,
                Customers = customers
            };



            return View(model);
        }
        public ActionResult Index()
        {

            var movie = new Movie() { Name = "Titans!",id=123 };
            ViewBag.TempName = "Hello World";

            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home");

            return View(movie);
        }
        public ActionResult Edit (int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index2(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Year";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }


        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}