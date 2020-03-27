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
            var movie = new List<Movie>()
            {
                new Movie{Id = 1, Name = "Harry Potter!"},
                new Movie{Id = 2, Name = "Avengers!"},
                new Movie{Id = 2, Name = "Iron Man!"}
            };
          var vm = new RandomMovieViewModel
            {
                Movie = movie,
            };
            return View("Movies", vm);


           // return Content("Hello World"); //Return the text Hello World
            //return HttpNotFound();  //Return 404 error
            //return new EmptyResult();// Return nothing like void 
           // return RedirectToAction("Index","Home",new{page=1,sortBy="name"});
        }

        public ActionResult Details(int id)
        {
            var name = "";
            switch (id)
            {
                case 1:
                    name = "Harry Potter!";
                    break;
                case 2:
                    name = "Avengers";
                    break;
                case 3:
                    name = "IronMan!";
                    break;
                default:
                    return HttpNotFound();
            }
            var movie = new Movie()
            {
                Name = name
            };
           
            return PartialView("_Details", movie);
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}