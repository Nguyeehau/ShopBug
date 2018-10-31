using ShopBug.Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopBug.Web.Controllers
{
    public class ProductControllerController : Controller
    {
        // GET: ProductController
        public ActionResult Index()
        {
            var productDao = new ProductDao();
            ViewBag.SellProduct = productDao.ListSellProduct(3);
            return View();
        }
    }
}