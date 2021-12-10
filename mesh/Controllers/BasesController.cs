using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mesh.Models;

namespace mesh.Controllers
{
    public class BasesController : Controller
    {
        private meshContext db = new meshContext();

        // GET: Bases
        public ActionResult Index()
        {
            return View(db.Bases.ToList());
        }

        // GET: Bases/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Base @base = db.Bases.Find(id);
            if (@base == null)
            {
                return HttpNotFound();
            }
            return View(@base);
        }

        // GET: Bases/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bases/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Base @base)
        {
            if (ModelState.IsValid)
            {
                db.Bases.Add(@base);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(@base);
        }

        // GET: Bases/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Base @base = db.Bases.Find(id);
            if (@base == null)
            {
                return HttpNotFound();
            }
            return View(@base);
        }

        // POST: Bases/Edit/5
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Base @base)
        {
            if (ModelState.IsValid)
            {
                db.Entry(@base).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(@base);
        }

        // GET: Bases/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Base @base = db.Bases.Find(id);
            if (@base == null)
            {
                return HttpNotFound();
            }
            return View(@base);
        }

        // POST: Bases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Base @base = db.Bases.Find(id);
            db.Bases.Remove(@base);
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
