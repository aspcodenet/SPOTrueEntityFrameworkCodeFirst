using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxMVCTest1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            using (var context = new AjaxMVCTest1.Models.Model1())
            {
                var prod = context.Products.FirstOrDefault(r => r.Id == 1);
                var catName = prod.Category.Name;
            }

                return View();


        }

        public ActionResult Showcat(int id)
        {
            using (var context = new AjaxMVCTest1.Models.Model1())
            {
                var cat = context.Categories.FirstOrDefault(r => r.Id == id);
                var catName = cat.Name;

                foreach(var prod in cat.Products)
                {

                }
            }

            return View();
        }

        public ActionResult GetPartialCategories()
        {
            return PartialView();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}