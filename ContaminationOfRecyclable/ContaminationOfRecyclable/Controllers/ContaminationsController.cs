using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContaminationOfRecyclable.Models;

namespace ContaminationOfRecyclable.Controllers
{
    public class ContaminationsController : Controller
    {
        private Contamination_Models db = new Contamination_Models();

        // GET: Contaminations
        public ActionResult Index()
        {
            return View(db.Contaminations.ToList());
        }

        // GET: Contaminations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contamination contamination = db.Contaminations.Find(id);
            if (contamination == null)
            {
                return HttpNotFound();
            }
            return View(contamination);
        }

        // GET: Contaminations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contaminations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,period,contamination_rate")] Contamination contamination)
        {
            if (ModelState.IsValid)
            {
                db.Contaminations.Add(contamination);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contamination);
        }

        // GET: Contaminations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contamination contamination = db.Contaminations.Find(id);
            if (contamination == null)
            {
                return HttpNotFound();
            }
            return View(contamination);
        }

        // POST: Contaminations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,period,contamination_rate")] Contamination contamination)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contamination).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contamination);
        }

        // GET: Contaminations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contamination contamination = db.Contaminations.Find(id);
            if (contamination == null)
            {
                return HttpNotFound();
            }
            return View(contamination);
        }

        // POST: Contaminations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contamination contamination = db.Contaminations.Find(id);
            db.Contaminations.Remove(contamination);
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
