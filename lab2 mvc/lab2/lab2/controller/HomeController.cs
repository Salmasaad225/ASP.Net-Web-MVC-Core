using lab2.model;
using Microsoft.AspNetCore.Mvc;

namespace lab2.controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           Context_DB db = new Context_DB();
            var cities = db.cities.ToList();
            return View("Index", cities);
        }
    }
}
