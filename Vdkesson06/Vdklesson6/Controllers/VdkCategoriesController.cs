using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vdklesson06CF.Models;

namespace Vdklesson06CF.Controllers
{
    public class VdkCategoriesController : Controller
    {
        private static VdkBookStore VdkDb;
        public VdkCategoriesController()
        {
            vdkDb = new VdkBookStore();
        }
        // GET: VdkCategories
        public ActionResult VdkIndex()
        {
            // VdkBookStore vdkDb = new VdkBookStore();
            var vdkCategories = vdkDb.VdkCategories.ToList();
            return View(vdkCategories);
        }
        public ActionResult VdkCreate()
        {
            var pvvCategory = new VdkBookStore();
            return View(vdkCategory);
        }
        [HttpPost]
        public ActionResult VdkCreate(VdkCategory vdkCategory)
        {
            vdkDb.VdkCategories.Add(vdkCategory);
            vdkDb.SaveChanges();
            return RedirectToAction("VdkIndex");
        }
    }
}