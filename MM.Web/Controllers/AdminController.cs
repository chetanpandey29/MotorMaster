using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MM.Web.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ebay()
        {
            return View();
        }

        public ActionResult EbayLaunch(int id)
        {
            return View();
        }

        public ActionResult EbayTemplate(int id)
        {
            return View();
        }

        public ActionResult SeoSetup()
        {
            return View();
        }

        public ActionResult DealerStats()
        {
            return View();
        }

        public ActionResult ClickReport()
        {
            return View();
        }
        public ActionResult Sellers()
        {
            return View();
        }

        public ActionResult SellerDetails(int id)
        {
            return View();
        }
    }
}