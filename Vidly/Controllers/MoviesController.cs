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
            var movie = new Movie() {Name = "Harry Potter!"};
            var customers = new List<Customer>()
            {
                new Customer{ Name = "Customer 1"},
                new Customer{Name = "Customer 2"}
            };
            var vm = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(vm);


           // return Content("Hello World"); //Return the text Hello World
            //return HttpNotFound();  //Return 404 error
            //return new EmptyResult();// Return nothing like void 
           // return RedirectToAction("Index","Home",new{page=1,sortBy="name"});
        }

        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year,int month)
        //{
        //    return Content(year+"/"+month);
        //}
    }
}