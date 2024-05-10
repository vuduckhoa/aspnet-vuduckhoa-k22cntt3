using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lessonOnline_vdk.Controllers
{
    /// <summary>
    /// author: vuduckhoa
    /// class : k22cnt3
    /// </summary>
    public class VDKStudentController : Controller
    {
        // GET: VDKStudent
        public ActionResult Index()
        {
            // truyen du lieu tu controller -> view
            ViewBag.fullname = "vuduckhoa";
            ViewData["Birthday"] = "27/08/2004";
            TempData["Phone"] = "0567699711";
            return View();
        }
        public ActionResult Details()
        {
            string vdkStr = "";
            vdkStr += "<h3>ho va ten:vu duc khoa</h3>";
            vdkStr += "<p>ma so : 2210900032";
            vdkStr += "<p>dia chi maill: vdk@gmail.com";

            ViewBag.Details = vdkStr;

            return View("ChiTiet");
        }
        public ActionResult NgonNguRazor()
        {
            string[] names = { "vuduckhoa", "khoacute", "duckhoa", "khoadeptrai" };
            ViewBag.names = names;
            return View();
        }
        // html helper
        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form)
        {
            // lay du lieu tren form
            string fullname = form["fullname"];
            string MaSV = form["MaSV"];
            string taikhoan = form["taikhoan"];
            string matkhau = form["matkhau"];

            string vdkstr = "<h3>" + fullname+ "</h3>";
            vdkstr += "<p>" + MaSV;
            vdkstr += "<p>" + taikhoan;
            vdkstr += "<p>" + matkhau;

            ViewBag.info = vdkstr;

            return View("ketqua");
        }
    }
}