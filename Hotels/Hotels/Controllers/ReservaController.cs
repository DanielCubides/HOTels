using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotels.Models;
using WebMatrix.WebData;

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

        /* Give a list of CurrentUser's reservas*/
        public ActionResult Lista() {
            //obtenemos las reservas de la base de datos
            var reservas = db.Reservas.Include(r => r.Habitacion);
            //creamos una lista con estas reservas
            List<Reserva> listadereservas = reservas.ToList();
            //una lista auxiliar donde guardaremos las reservas del usuario
            List<Reserva> reservasDelUsuario = new List<Reserva>();
            //para cada reserva en la lista de las reservas
            foreach (Reserva r in listadereservas)
            {
                //si es del usuario agreguela a la lista de las reservas del usuario
                if (r.UsuarioID == WebSecurity.CurrentUserId) {
                    reservasDelUsuario.Add(r);
                }
            }
            //retorne la lista de las reservas del usuario
            return View(reservasDelUsuario);
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
            return View();
        }

        //
        // POST: /Reserva/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Reserva reserva)
        {
            var reservas = db.Reservas.Include(r => r.Habitacion);
            List<Reserva> listadereservas = reservas.ToList();
            foreach (Reserva r in listadereservas)
            {
                if (reserva.HabitacionID == r.HabitacionID)
                {
                    if ((reserva.StartDate <= r.EndDate && reserva.StartDate >= r.StartDate) ||
                    (reserva.EndDate <= r.EndDate && reserva.EndDate >= r.StartDate))
                    {
                        return RedirectToAction("Lista");
                    }
                
                }
                

            }



            //-----------------Si todo va bien guarde la reserva---------
            reserva.UsuarioID = WebSecurity.CurrentUserId;
            if (ModelState.IsValid)
            {
                
                db.Reservas.Add(reserva);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HabitacionID = new SelectList(db.Habitacions, "ID", "ID", reserva.HabitacionID);
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
    }
}