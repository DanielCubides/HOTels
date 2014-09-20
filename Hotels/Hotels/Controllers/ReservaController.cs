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
    public class ReservaController : Controller
    {
        private DBContext db = new DBContext();

        //
        // GET: /Reserva/

        public ActionResult Index()
        {
            var reservas = db.Reservas.Include(r => r.Habitacion);
            return View(reservas.ToList());
        }

        //
        // GET: /Reserva/Details/5

        public ActionResult Details(int id = 0)
        {
            Reserva reserva = db.Reservas.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            return View(reserva);
        }

        //
        // GET: /Reserva/Create

        public ActionResult Create()
        {
            ViewBag.HabitacionID = new SelectList(db.Habitacions, "ID", "ID");
            ViewBag.UserProfileID = new SelectList(db.UserProfiles , "ID", "ID");

            return View();
        }

        //
        // POST: /Reserva/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                db.Reservas.Add(reserva);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            ViewBag.HabitacionID = new SelectList(db.Habitacions, "ID", "ID", reserva.HabitacionID);
            ViewBag.UserProfileID = new SelectList(db.UserProfiles, "ID", "ID", reserva.usuario);
            return View(reserva);
        }

        //
        // GET: /Reserva/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Reserva reserva = db.Reservas.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            ViewBag.HabitacionID = new SelectList(db.Habitacions, "ID", "ID", reserva.HabitacionID);
            return View(reserva);
        }

        //
        // POST: /Reserva/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reserva).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HabitacionID = new SelectList(db.Habitacions, "ID", "ID", reserva.HabitacionID);
            return View(reserva);
        }

        //
        // GET: /Reserva/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Reserva reserva = db.Reservas.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            return View(reserva);
        }

        //
        // POST: /Reserva/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reserva reserva = db.Reservas.Find(id);
            db.Reservas.Remove(reserva);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        //
        // GET: /Reserva/IngresarFechas

        public ActionResult IngresarFechas()
        {
            ViewBag.HabitacionID = new SelectList(db.Habitacions, "ID", "ID");
            ViewBag.UserProfileID = new SelectList(db.UserProfiles, "ID", "ID");

            return View();
        }

        //
        // POST: /Reserva/IngresarFechas

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IngresarFechas(Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                db.Reservas.Add(reserva);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HabitacionID = new SelectList(db.Habitacions, "ID", "ID", reserva.HabitacionID);
            ViewBag.UserProfileID = new SelectList(db.UserProfiles, "ID", "ID", reserva.usuario);
            return View(reserva);
        }


    
    


    }

     
}