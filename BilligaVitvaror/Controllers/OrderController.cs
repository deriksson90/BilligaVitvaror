using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BilligaVitvaror.Models;


namespace BilligaVitvaror.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Details(int id)
        {
            var category = new Category { CategoryId = 1, CategoryName = "Electronics" };

            var item = new Item { ItemId = 1, TitleName = "Test", Price =2000, Category = category, Volume = 300, Weight = 200 };
            return View(item);
        }

        public ActionResult Browse()
        {
            var items = new Item() { TitleName = "Lampa"};
            return View(items);

        }



    }
}