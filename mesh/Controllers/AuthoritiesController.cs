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
    public class AuthoritiesController : Controller
    {
        private meshContext db = new meshContext();

        // GET: Authorities
        public ActionResult Index()
        {
            return View(db.Authorities.ToList());
        }

        // GET: Authorities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Authority authority = db.Authorities.Find(id);
            if (authority == null)
            {
                return HttpNotFound();
            }
            return View(authority);
        }

        // GET: Authorities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Authorities/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Authority authority)
        {
            if (ModelState.IsValid)
            {
                db.Authorities.Add(authority);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(authority);
        }

        // GET: Authorities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Authority authority = db.Authorities.Find(id);
            if (authority == null)
            {
                return HttpNotFound();
            }
            return View(authority);
        }

        // POST: Authorities/Edit/5
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Authority authority)
        {
            if (ModelState.IsValid)
            {
                db.Entry(authority).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(authority);
        }

        // GET: Authorities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Authority authority = db.Authorities.Find(id);
            if (authority == null)
            {
                return HttpNotFound();
            }
            return View(authority);
        }

        // POST: Authorities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Authority authority = db.Authorities.Find(id);
            db.Authorities.Remove(authority);
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
