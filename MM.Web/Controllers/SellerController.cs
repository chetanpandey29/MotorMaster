using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MM.Web.Controllers
{
    public class SellerController : Controller
    {
        // GET: Dealer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listing()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult AddCar()
        {
            return View();
        }
    }
}