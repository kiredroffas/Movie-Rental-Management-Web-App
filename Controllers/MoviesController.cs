using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movie_Rental_Management_Web_App.Models;

namespace Movie_Rental_Management_Web_App.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            return View(movie);              //Return Shrek!
            
            //Other types of Action Results:
            //return Content("Hello World");   //Return plain content
            //return HttpNotFound();           //Return generic 404 error
            //return new EmptyResult();        //Return nothing
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" } ); //Redirect to another page
        }
    }
}