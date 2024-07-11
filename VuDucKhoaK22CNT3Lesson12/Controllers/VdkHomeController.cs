using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VuDucKhoaK22CNT3Lesson12.Controllers
{
    public class VdkHomeController : Controller
    {
        public ActionResult VdkIndex()
        {
            return View();
        }

        public ActionResult VdkAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult VdkContact()
        {
            ViewBag.msv = "2210900032";
            ViewBag.fullname = "Vu Duc Khoa";

            return View();
        }
    }
}