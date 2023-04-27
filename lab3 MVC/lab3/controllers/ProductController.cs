using lab3.models;
using lab3.models.category;
using lab3.models.product;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace lab3.NewFolder
{
    public class ProductController : Controller
    {
        Context_DB context = new Context_DB();
        public IActionResult get_products()
        {
           
            var products = context.products;

            
            ViewBag.products = products;
            return View();
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {

            context.Add(product);
            context.SaveChanges();
            return View();
        }


        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            context.Update(product);
            context.SaveChanges();
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete( long id)
        {
            var Deleted = context.products.Find(id);
            context.products.Remove(Deleted);
            context.SaveChanges();
            return View();
        }


       
    }

}
