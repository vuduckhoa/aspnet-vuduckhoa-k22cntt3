using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VdkK22CNT3Lesson11Db2210900032.Models;

namespace VdkK22CNT3Lesson11Db2210900032.Controllers
{
    public class VdkCategoriesController : Controller
    {
        private VdkK22CNT3Less11DbEntities db = new VdkK22CNT3Less11DbEntities();

        // GET: VdkCategories
        public ActionResult VdkIndex()
        {
            return View(db.VdkCategory.ToList());
        }

        // GET: VdkCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VdkCategory vdkCategory = db.VdkCategory.Find(id);
            if (vdkCategory == null)
            {
                return HttpNotFound();
            }
            return View(vdkCategory);
        }

        // GET: VdkCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VdkCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VdkID,VdkCateName,VdkStatus")] VdkCategory vdkCategory)
        {
            if (ModelState.IsValid)
            {
                db.VdkCategory.Add(vdkCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vdkCategory);
        }

        // GET: VdkCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VdkCategory vdkCategory = db.VdkCategory.Find(id);
            if (vdkCategory == null)
            {
                return HttpNotFound();
            }
            return View(vdkCategory);
        }

        // POST: VdkCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VdkID,VdkCateName,VdkStatus")] VdkCategory vdkCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vdkCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vdkCategory);
        }

        // GET: VdkCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VdkCategory vdkCategory = db.VdkCategory.Find(id);
            if (vdkCategory == null)
            {
                return HttpNotFound();
            }
            return View(vdkCategory);
        }

        // POST: VdkCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VdkCategory vdkCategory = db.VdkCategory.Find(id);
            db.VdkCategory.Remove(vdkCategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
