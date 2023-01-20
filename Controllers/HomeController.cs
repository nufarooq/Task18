using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task18_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "Mobile", Value = "10000" });
            items.Add(new SelectListItem { Text = "Laptop", Value = "50000" });
            items.Add(new SelectListItem { Text = "Watch", Value = "8000" });
            items.Add(new SelectListItem { Text = "HeadPhones", Value = "4000" });
            ViewBag.Store = new SelectList(items, "Value", "Text");
            return View();
        }

        public ActionResult GetImage(string ImageName)
        {
            string Path = Server.MapPath("~/Images/"+ImageName + ".jpg");
            string outfile = Path;

            string fileToSend = Convert.ToBase64String(System.IO.File.ReadAllBytes(outfile));

            return Json(fileToSend, JsonRequestBehavior.AllowGet);
        }
    }
}