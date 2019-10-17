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



    }

}