using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VdkK22CNT3Lesson10Db.Models;

namespace VdkK22CNT3Lesson10Db.Controllers
{
    public class VdkAccountsController : Controller
    {
        private VdkK22CNT3Lesoon10DBEntities db = new VdkK22CNT3Lesoon10DBEntities();

        // GET: VdkAccounts
        public async Task<ActionResult> Index()
        {
            return View(await db.VdkAccount.ToListAsync());
        }

        // GET: VdkAccounts/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VdkAccount vdkAccount = await db.VdkAccount.FindAsync(id);
            if (vdkAccount == null)
            {
                return HttpNotFound();
            }
            return View(vdkAccount);
        }

        // GET: VdkAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VdkAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "VdkID,VdkUserName,VdkPassword,VdkFullName,VdkEmail,VdkPhone,VdkActive")] VdkAccount vdkAccount)
        {
            if (ModelState.IsValid)
            {
                db.VdkAccount.Add(vdkAccount);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(vdkAccount);
        }

        // GET: VdkAccounts/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VdkAccount vdkAccount = await db.VdkAccount.FindAsync(id);
            if (vdkAccount == null)
            {
                return HttpNotFound();
            }
            return View(vdkAccount);
        }

        // POST: VdkAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "VdkID,VdkUserName,VdkPassword,VdkFullName,VdkEmail,VdkPhone,VdkActive")] VdkAccount vdkAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vdkAccount).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(vdkAccount);
        }

        // GET: VdkAccounts/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VdkAccount vdkAccount = await db.VdkAccount.FindAsync(id);
            if (vdkAccount == null)
            {
                return HttpNotFound();
            }
            return View(vdkAccount);
        }

        // POST: VdkAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            VdkAccount vdkAccount = await db.VdkAccount.FindAsync(id);
            db.VdkAccount.Remove(vdkAccount);
            await db.SaveChangesAsync();
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
        // login 
        public ActionResult VdkLogin()
        {
            var VdkModel = new VdkAccount();
            return View(VdkModel);
        }
        [HttpPost]
        public ActionResult VdkLogin(VdkAccount vdkAccount)
        {
            var vdkCheck = db.VdkAccount.Where(x=>x.VdkUserName.Equals(vdkAccount.VdkUserName) && x.VdkPassword.Equals(vdkAccount.VdkPassword)).FirstOrDefault();
            if (vdkCheck != null)
            {
                Session["VdkAccount"] = vdkCheck;
                return Redirect("/");
            }
            return View(vdkAccount);
        }
    }
}
