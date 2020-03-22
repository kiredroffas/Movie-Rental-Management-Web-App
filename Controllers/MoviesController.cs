using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movie_Rental_Management_Web_App.Models;
using Movie_Rental_Management_Web_App.ViewModels;

namespace Movie_Rental_Management_Web_App.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);              //Return Shrek!

            //Other types of Action Results:
            //return Content("Hello World");   //Return plain content
            //return HttpNotFound();           //Return generic 404 error
            //return new EmptyResult();        //Return nothing
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" } ); //Redirect to another page
        }

        //Action Parameters:
        //Set up in App_Start/RouteConfig.cs
        //https://localhost:44341/movies/edit/1
        //https://localhost:44341/movies/edit?id=2
        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}

        // movies
        //https://localhost:44341/movies?pageIndex=2&sortBy=ReleaseDate
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    
        //    //Returns defaults if parameters are not given in URL
        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        //Custom route
        //https://localhost:44341/movies/released/2015/04
        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}