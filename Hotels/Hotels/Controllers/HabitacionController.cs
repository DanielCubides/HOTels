using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotels.Models;

namespace Hotels.Controllers
{
    public class HabitacionController : Controller
    {
        private DBContext db = new DBContext();

        //
        // GET: /Habitacion/

        public ActionResult Index()
        {
            return View(db.Habitacions.ToList());
        }

        //
        // GET: /Habitacion/Details/5

        public ActionResult Details(int id = 0)
        {
            Habitacion habitacion = db.Habitacions.Find(id);
            if (habitacion == null)
            {
                return HttpNotFound();
            }
            return View(habitacion);
        }

        //
        // GET: /Habitacion/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Habitacion/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Habitacion habitacion)
        {
            if (ModelState.IsValid)
            {
                db.Habitacions.Add(habitacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(habitacion);
        }

        //
        // GET: /Habitacion/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Habitacion habitacion = db.Habitacions.Find(id);
            if (habitacion == null)
            {
                return HttpNotFound();
            }
            return View(habitacion);
        }

        //
        // POST: /Habitacion/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Habitacion habitacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(habitacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(habitacion);
        }

        //
        // GET: /Habitacion/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Habitacion habitacion = db.Habitacions.Find(id);
            if (habitacion == null)
            {
                return HttpNotFound();
            }
            return View(habitacion);
        }

        //
        // POST: /Habitacion/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Habitacion habitacion = db.Habitacions.Find(id);
            db.Habitacions.Remove(habitacion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}