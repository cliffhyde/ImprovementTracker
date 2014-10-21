using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ImprovementTracker.Models;

namespace ImprovementTracker.Controllers
{
    public class ImprovementsController : Controller
    {
        private ImprovementTrackerContext db = new ImprovementTrackerContext();

        // GET: Improvements
        public ActionResult Index()
        {
            return View(Improvement.GetOrderedImprovement(db));
        }

        // GET: Improvements/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Improvement improvement = db.Improvements.Find(id);
            if (improvement == null)
            {
                return HttpNotFound();
            }
            return View(improvement);
        }

        // GET: Improvements/Create
        public ActionResult Create()
        {
            ViewBag.StatusList = new SelectList(db.Statuses, "Id", "StatusName");
            return View();
        }

        // POST: Improvements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description,StatusId")] Improvement improvement)
        {
            if (ModelState.IsValid)
            {
                db.Improvements.Add(improvement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StatusList = new SelectList(db.Statuses, "Id", "StatusName");
            return View(improvement);
        }

        // GET: Improvements/Edit/5
        public ActionResult Edit(int? id)
        {
            ViewBag.StatusList = new SelectList(db.Statuses, "Id", "StatusName"); 

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Improvement improvement = db.Improvements.Find(id);
            if (improvement == null)
            {
                return HttpNotFound();
            }
            return View(improvement);
        }

        // POST: Improvements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description,StatusId")] Improvement improvement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(improvement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StatusList = new SelectList(db.Statuses, "Id", "StatusName");
            return View(improvement);
        }

        // GET: Improvements/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Improvement improvement = db.Improvements.Find(id);
            if (improvement == null)
            {
                return HttpNotFound();
            }
            return View(improvement);
        }

        // POST: Improvements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Improvement improvement = db.Improvements.Find(id);
            db.Improvements.Remove(improvement);
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
