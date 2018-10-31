using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopDunk.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Slides = new SlideDao().ListAll();
            var productDao = new ProductDao();
            ViewBag.SellProduct = productDao.ListSellProduct(4); 
            return View();
        }

        [ChildActionOnly]
        public ActionResult MainMenu() {
            var model = new MenuDao().ListByGroupID(1);
            return PartialView(model);
        }

        [ChildActionOnly]
        public ActionResult Foodter()
        {
            var model = new FooterDao().GetFooter();
            return PartialView(model);
        }
    }
}