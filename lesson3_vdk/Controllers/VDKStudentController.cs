using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson3_vdk.Controllers
{
    public class VDKStudentController : Controller
    {
        // GET: VDKStudent
        public ActionResult Index()
        {
            // du lieu tu view data 
            ViewData["msg"] = "ViewData -vuduckhoa";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy tt");
            return View();
        }

        public ActionResult StudentList()
        {
            // su dung viewbag
            // luu tru gia tri don
            ViewBag.titleName = "danh sach hoc vien - vuduckhoa";

            //gia tri la 1 tap hop
            string[] names = { " duc khoa ", "vu khoa", "khoa cute" };
            ViewBag.list = names;

            // gia tri la 1 doi tuong
            var obj = new
            {
                ID=100,
                Name = "duckhoa",
                Age=45
            };
            ViewBag.student = obj;
            return View();
        }
        public ActionResult Insert()
        {
            return View("AddStudent");
        }
    }
}