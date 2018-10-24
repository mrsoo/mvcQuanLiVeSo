using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VesoQuanli.Models;

namespace VesoQuanli.Controllers
{
    public class dailisController : Controller
    {
        private VesoContext db = new VesoContext();

        // GET: dailis
        public ActionResult Index()
        {
            return View(db.Dailis.ToList());
        }

        // GET: dailis/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            daili daili = db.Dailis.Find(id);
            if (daili == null)
            {
                return HttpNotFound();
            }
            return View(daili);
        }

        // GET: dailis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: dailis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TenDaili,diachi")] daili daili)
        {
            if (ModelState.IsValid)
            {
                db.Dailis.Add(daili);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(daili);
        }

        // GET: dailis/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            daili daili = db.Dailis.Find(id);
            if (daili == null)
            {
                return HttpNotFound();
            }
            return View(daili);
        }

        // POST: dailis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TenDaili,diachi")] daili daili)
        {
            if (ModelState.IsValid)
            {
                db.Entry(daili).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(daili);
        }

        // GET: dailis/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            daili daili = db.Dailis.Find(id);
            if (daili == null)
            {
                return HttpNotFound();
            }
            return View(daili);
        }

        // POST: dailis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            daili daili = db.Dailis.Find(id);
            db.Dailis.Remove(daili);
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
