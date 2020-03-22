using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Movie_Rental_Management_Web_App.Models;

namespace Movie_Rental_Management_Web_App.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}