using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Models.HomeViewModel model = new Models.HomeViewModel();
            model.FeaturedProperties = MvcApplication.GetPropertyRepository.All.Where(p => p.Featured == true).ToList();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
    }
}