using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VuDucKhoaK22CNT3Lesson12.Models;

namespace VuDucKhoaK22CNT3Lesson12.Controllers
{
    public class Vdk_TACGIAController : Controller
    {
        private VuDucKhoaa_2210900032Entities db = new VuDucKhoaa_2210900032Entities();

        // GET: Vdk_TACGIA
        public ActionResult VdkIndex()
        {
            return View(db.Vdk_TACGIA.ToList());
        }

        // GET: Vdk_TACGIA/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vdk_TACGIA vdk_TACGIA = db.Vdk_TACGIA.Find(id);
            if (vdk_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(vdk_TACGIA);
        }

        // GET: Vdk_TACGIA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vdk_TACGIA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Vdk_MaTG,Vdk_TenTG")] Vdk_TACGIA vdk_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Vdk_TACGIA.Add(vdk_TACGIA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vdk_TACGIA);
        }

        // GET: Vdk_TACGIA/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vdk_TACGIA vdk_TACGIA = db.Vdk_TACGIA.Find(id);
            if (vdk_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(vdk_TACGIA);
        }

        // POST: Vdk_TACGIA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Vdk_MaTG,Vdk_TenTG")] Vdk_TACGIA vdk_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vdk_TACGIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vdk_TACGIA);
        }

        // GET: Vdk_TACGIA/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vdk_TACGIA vdk_TACGIA = db.Vdk_TACGIA.Find(id);
            if (vdk_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(vdk_TACGIA);
        }

        // POST: Vdk_TACGIA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Vdk_TACGIA vdk_TACGIA = db.Vdk_TACGIA.Find(id);
            db.Vdk_TACGIA.Remove(vdk_TACGIA);
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
