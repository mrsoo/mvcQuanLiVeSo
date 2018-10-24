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
    public class soluongdkiesController : Controller
    {
        private VesoContext db = new VesoContext();

        // GET: soluongdkies
        public ActionResult Index()
        {
            return View(db.Soluongdkys.ToList());
        }

        // GET: soluongdkies/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            soluongdky soluongdky = db.Soluongdkys.Find(id);
            if (soluongdky == null)
            {
                return HttpNotFound();
            }
            return View(soluongdky);
        }

        // GET: soluongdkies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: soluongdkies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,sldky,Ngay")] soluongdky soluongdky)
        {
            if (ModelState.IsValid)
            {
                db.Soluongdkys.Add(soluongdky);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(soluongdky);
        }

        // GET: soluongdkies/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            soluongdky soluongdky = db.Soluongdkys.Find(id);
            if (soluongdky == null)
            {
                return HttpNotFound();
            }
            return View(soluongdky);
        }

        // POST: soluongdkies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,sldky,Ngay")] soluongdky soluongdky)
        {
            if (ModelState.IsValid)
            {
                db.Entry(soluongdky).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(soluongdky);
        }

        // GET: soluongdkies/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            soluongdky soluongdky = db.Soluongdkys.Find(id);
            if (soluongdky == null)
            {
                return HttpNotFound();
            }
            return View(soluongdky);
        }

        // POST: soluongdkies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            soluongdky soluongdky = db.Soluongdkys.Find(id);
            db.Soluongdkys.Remove(soluongdky);
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
