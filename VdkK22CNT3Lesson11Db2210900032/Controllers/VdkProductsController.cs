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
    public class VdkProductsController : Controller
    {
        private VdkK22CNT3Less11DbEntities db = new VdkK22CNT3Less11DbEntities();

        // GET: VdkProducts
        public ActionResult VdkIndex()
        {
            return View(db.VdkProduct.ToList());
        }

        // GET: VdkProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VdkProduct vdkProduct = db.VdkProduct.Find(id);
            if (vdkProduct == null)
            {
                return HttpNotFound();
            }
            return View(vdkProduct);
        }

        // GET: VdkProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VdkProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VdkId2210900032,VdkProName,VdkQty,VdkPrice,VdkCateId,VdkActive")] VdkProduct vdkProduct)
        {
            if (ModelState.IsValid)
            {
                db.VdkProduct.Add(vdkProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vdkProduct);
        }

        // GET: VdkProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VdkProduct vdkProduct = db.VdkProduct.Find(id);
            if (vdkProduct == null)
            {
                return HttpNotFound();
            }
            return View(vdkProduct);
        }

        // POST: VdkProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VdkId2210900032,VdkProName,VdkQty,VdkPrice,VdkCateId,VdkActive")] VdkProduct vdkProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vdkProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vdkProduct);
        }

        // GET: VdkProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VdkProduct vdkProduct = db.VdkProduct.Find(id);
            if (vdkProduct == null)
            {
                return HttpNotFound();
            }
            return View(vdkProduct);
        }

        // POST: VdkProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VdkProduct vdkProduct = db.VdkProduct.Find(id);
            db.VdkProduct.Remove(vdkProduct);
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
