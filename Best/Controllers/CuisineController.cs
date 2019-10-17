using Microsoft.AspNetCore.Mvc;
using Best.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Best.Controllers
{
    public class CuisineController:Controller
    {
        private readonly BestContext _db;
        public CuisineController(BestContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Cuisine> model = _db.Cuisines.Include(m => m.Restaurant).ToList();
            // ViewBag.RestaurantId = id;
            return View(model);
        }

        public ActionResult Create(int id)
        {
            ViewBag.RestaurantId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Create(int id, Cuisine cuisine)
        {
            _db.Cuisines.Add(cuisine);
            _db.SaveChanges();
            return RedirectToAction("Details", "Restaurant", id);
        }

        public ActionResult Details(int id)
        {
            Cuisine thisCuisine = _db.Cuisines.FirstOrDefault(m => m.CuisineId == id);
            return View(thisCuisine);
        }
    }
}