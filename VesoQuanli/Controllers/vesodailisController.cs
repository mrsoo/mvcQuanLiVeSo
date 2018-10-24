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
    public class vesodailisController : Controller
    {
        private VesoContext db = new VesoContext();

        // GET: vesodailis
        public ActionResult Index()
        {
            return View(db.Vesodailis.ToList());
        }

        // GET: vesodailis/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vesodaili vesodaili = db.Vesodailis.Find(id);
            if (vesodaili == null)
            {
                return HttpNotFound();
            }
            return View(vesodaili);
        }

        // GET: vesodailis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: vesodailis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Idloaiveso,soluong,slbandc,Date,Iddaili,idveso")] vesodaili vesodaili)
        {
            if (ModelState.IsValid)
            {
                db.Vesodailis.Add(vesodaili);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vesodaili);
        }

        // GET: vesodailis/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vesodaili vesodaili = db.Vesodailis.Find(id);
            if (vesodaili == null)
            {
                return HttpNotFound();
            }
            return View(vesodaili);
        }

        // POST: vesodailis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Idloaiveso,soluong,slbandc,Date,Iddaili,idveso")] vesodaili vesodaili)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vesodaili).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vesodaili);
        }

        // GET: vesodailis/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vesodaili vesodaili = db.Vesodailis.Find(id);
            if (vesodaili == null)
            {
                return HttpNotFound();
            }
            return View(vesodaili);
        }

        // POST: vesodailis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            vesodaili vesodaili = db.Vesodailis.Find(id);
            db.Vesodailis.Remove(vesodaili);
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
