using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MM.Web.Controllers
{
    public class HomeController : Controller
    {
        private MotorMastersDataEntities db = new MotorMastersDataEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

        public ActionResult Listing()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return View();
        }

        [HttpGet]        
        public ActionResult Login()
        {            
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            db.Users.Where(a => a.Email == user.Email);            
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Export()
        {
            DataTable dt = new DataTable();
            User u = new User();
            var query = (from c in db.Users select c).ToList();
            foreach (var item in query) {
                dt.Columns.Add("Email");
                dt.Rows.Add(item.Email);
            }
            
            string attachment = "attachment; filename=city.xls";
            Response.ClearContent();
            Response.AddHeader("content-disposition", attachment);
            Response.ContentType = "application/vnd.ms-excel";
            string tab = "";
            foreach (DataColumn dc in dt.Columns)
            {
                Response.Write(tab + dc.ColumnName);
                tab = "\t";
            }
            Response.Write("\n");
            int i;
            foreach (DataRow dr in dt.Rows)
            {
                tab = "";
                for (i = 0; i < dt.Columns.Count; i++)
                {
                    Response.Write(tab + dr[i].ToString());
                    tab = "\t";
                }
                Response.Write("\n");
            }
            Response.End();

            return RedirectToAction("Index");
        }

    }
}