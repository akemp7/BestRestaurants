using Microsoft.AspNetCore.Mvc;
using Best.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Best.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly BestContext _db;

        public RestaurantController(BestContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Restaurant> model = _db.Restaurants.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Restaurant restaurants) //the parameter name "restaurants" refers to the actual table in the database, so it must have the same name as the table otherwise it will yell at you.
        {
            _db.Restaurants.Add(restaurants);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }

}