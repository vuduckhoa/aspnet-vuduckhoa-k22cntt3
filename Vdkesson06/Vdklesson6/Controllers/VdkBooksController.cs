using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Vdklesson06CF.Models;

namespace Vdklesson06CF.Controllers
{
    public class VdkBooksController : Controller
    {
        private VdkBookStore db = new VdkBookStore();

        // GET: VdkBooks
        public ActionResult Index()
        {
            return View(db.VdkBooks.ToList());
        }

        // GET: VdkBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VdkBook VdkBook = db.VdkBooks.Find(id);
            if (VdkBook == null)
            {
                return HttpNotFound();
            }
            return View(VdkBook);
        }

        // GET: PvvBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VdkBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VdkId,VdkBookId,VdkTitle,VdkAuthor,VdkYear,VdkPulisher,VdkPicture,VdkCategoryId")] VdkBook VdkBook)
        {
            if (ModelState.IsValid)
            {
                db.VdkBooks.Add(VdkBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(VdkBook);
        }

        // GET: VdkBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VdkBook VdkBook = db.VdkBooks.Find(id);
            if (VdkBook == null)
            {
                return HttpNotFound();
            }
            return View(VdkBook);
        }

        // POST: VdkBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VdkId,VdkBookId,VdkTitle,VdkAuthor,VdkYear,VdkPulisher,VdkPicture,VdkCategoryId")] VdkBook vdkBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vdkBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vdkBook);
        }

        // GET: VdkBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VdkBook vdkBook = db.VdkBooks.Find(id);
            if (vdkBook == null)
            {
                return HttpNotFound();
            }
            return View(vdkBook);
        }

        // POST: VdkBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VdkBook pvvBook = db.VdkBooks.Find(id);
            db.VdkBooks.Remove(vdkBook);
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
