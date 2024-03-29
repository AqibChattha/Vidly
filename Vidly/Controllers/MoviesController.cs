﻿using System;
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
            Movie movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer{Name = "Customer1"},
                new Customer{Name = "Customer2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }






        //public ActionResult Edit(int id)
        //{
        //    return Content("Id : " + id);
        //}
        //[Route("movies/released/{year}/{month:regex(//d{4}): range(1, 12)}")]
        //public ActionResult byReleaseYear(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }
        //    if (string.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }

        //    return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy)); 
        //}
         
    }
}