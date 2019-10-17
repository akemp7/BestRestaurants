using Microsoft.AspNetCore.Mvc;
using Best.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace Best.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly BestContext _db;

        public RestaurantController(BestContext db)
        {
            _db = db;
        }

        //Restaurant Index: displays list of restaurants in the database
        public ActionResult Index()
        {
            List<Restaurant> model = _db.Restaurants.ToList();
            return View(model);
        }

        //Restaurant Create: displays a form to make a new restaurant
        public ActionResult Create()
        {
            return View();
        }

        //Restaurant Create Post: Accepts new restaurant object, adds it to database, and redirects to Restaurant Index
        [HttpPost]
        public ActionResult Create(Restaurant restaurants) //the parameter name "restaurants" refers to the actual table in the database, so it must have the same name as the table otherwise it will yell at you.
        {
            _db.Restaurants.Add(restaurants);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Restaurant Details: displays list of cuisines for a particular restaurant ("int id" refers to the restaurant's ID)
        public ActionResult Details(int id)
        {
            Console.WriteLine(">>>>>ID passed in to Restaurant Controller Details Method: " + id);
            Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(rest=> rest.RestaurantId == id);
            return View(thisRestaurant);
        }

    }

}