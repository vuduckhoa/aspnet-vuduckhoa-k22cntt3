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
    public class Vdk_SACHController : Controller
    {
        private VuDucKhoaa_2210900032Entities db = new VuDucKhoaa_2210900032Entities();

        // GET: Vdk_SACH
        public ActionResult VdkIndex()
        {
            return View(db.Vdk_SACH.ToList());
        }

        // GET: Vdk_SACH/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vdk_SACH vdk_SACH = db.Vdk_SACH.Find(id);
            if (vdk_SACH == null)
            {
                return HttpNotFound();
            }
            return View(vdk_SACH);
        }

        // GET: Vdk_SACH/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vdk_SACH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Vdk_MaSach,Vdk_TenSach,Vdk_SoTrang,Vdk_NamXB,Vdk_MaTG,Vdk_TrangThai")] Vdk_SACH vdk_SACH)
        {
            if (ModelState.IsValid)
            {
                db.Vdk_SACH.Add(vdk_SACH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vdk_SACH);
        }

        // GET: Vdk_SACH/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vdk_SACH vdk_SACH = db.Vdk_SACH.Find(id);
            if (vdk_SACH == null)
            {
                return HttpNotFound();
            }
            return View(vdk_SACH);
        }

        // POST: Vdk_SACH/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Vdk_MaSach,Vdk_TenSach,Vdk_SoTrang,Vdk_NamXB,Vdk_MaTG,Vdk_TrangThai")] Vdk_SACH vdk_SACH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vdk_SACH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vdk_SACH);
        }

        // GET: Vdk_SACH/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vdk_SACH vdk_SACH = db.Vdk_SACH.Find(id);
            if (vdk_SACH == null)
            {
                return HttpNotFound();
            }
            return View(vdk_SACH);
        }

        // POST: Vdk_SACH/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Vdk_SACH vdk_SACH = db.Vdk_SACH.Find(id);
            db.Vdk_SACH.Remove(vdk_SACH);
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
