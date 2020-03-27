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
        // GET: Customers
        public ActionResult Random()
        {
            var customer = new List<Customer>()
            {
                new Customer{Id = 1, Name = "Sandesh"},
                new Customer{Id = 2, Name = "Mudit"},
                new Customer{Id = 3, Name = "Abhay"}
            };
            var vm = new RandomMovieViewModel
            {
                Customers = customer,
            };
            return View("Customer", vm);


            // return Content("Hello World"); //Return the text Hello World
            //return HttpNotFound();  //Return 404 error
            //return new EmptyResult();// Return nothing like void 
            // return RedirectToAction("Index","Home",new{page=1,sortBy="name"});
        }
    }
}