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
    public class ApplliesController : Controller
    {
        private meshContext db = new meshContext();

        // GET: Appllies
        public ActionResult Index()
        {
            return View(db.Appllies.ToList());
        }

        // GET: Appllies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applly applly = db.Appllies.Find(id);
            if (applly == null)
            {
                return HttpNotFound();
            }
            return View(applly);
        }

        // GET: Appllies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Appllies/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Description,Appllytype")] Applly applly)
        {
            if (ModelState.IsValid)
            {
                db.Appllies.Add(applly);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(applly);
        }

        // GET: Appllies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applly applly = db.Appllies.Find(id);
            if (applly == null)
            {
                return HttpNotFound();
            }
            return View(applly);
        }

        // POST: Appllies/Edit/5
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Description,Appllytype")] Applly applly)
        {
            if (ModelState.IsValid)
            {
                db.Entry(applly).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(applly);
        }

        // GET: Appllies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applly applly = db.Appllies.Find(id);
            if (applly == null)
            {
                return HttpNotFound();
            }
            return View(applly);
        }

        // POST: Appllies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Applly applly = db.Appllies.Find(id);
            db.Appllies.Remove(applly);
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
