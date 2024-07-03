using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VdkK22CNT3Lesson10Db.Models;

namespace VdkK22CNT3Lesson10Db.Controllers
{
    public class VdkHomeController : Controller
    {
        public ActionResult VdkIndex()
        {
            // kiem du lieu session
            if (Session["VdkAccount"] !=null)
            {
                var vdkAccount = Session["VdkAccount"] as VdkAccount;
                ViewBag.FullName= vdkAccount.VdkFullName;
            }
            return View();
        }

        public ActionResult VdkAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult VdkContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}