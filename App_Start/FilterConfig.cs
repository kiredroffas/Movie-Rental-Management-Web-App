﻿using System.Web;
using System.Web.Mvc;

namespace Movie_Rental_Management_Web_App
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
