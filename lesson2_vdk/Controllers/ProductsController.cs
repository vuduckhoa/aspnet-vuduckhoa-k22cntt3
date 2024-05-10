using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson2_vdk.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            ViewBag.name = "Vuduckhoa-2210900032";
            return View();
        }

        public ActionResult Details(int? id)
        {
            ViewBag.id = id;
            return View();
        }

        public string get_name()
        {
            return "vuduckhoa - 2210900032";
        }

        public JsonResult ListName()
        {
            string[] names = { "khoa", " mai", "hoa", "cute" };
            return Json(names, JsonRequestBehavior.AllowGet);
        }
    }
}