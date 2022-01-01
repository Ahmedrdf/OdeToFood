using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        IRestaurantsData db;
        //public HomeController()
        //{
        //    db = new InMemoryRestaurantData();
        //}

        public HomeController(IRestaurantsData db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            var models = db.GetAll();
            return View(models);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}