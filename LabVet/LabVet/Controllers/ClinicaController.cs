using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabVet.Models;
using LabVet.Models.DBContext;

namespace LabVet.Controllers
{
    public class ClinicaController : Controller
    {
        private ClinicaDB db = new ClinicaDB();

        //
        // GET: /Veterinario/

        public ActionResult Index()
        {
            return View(db.Clinicas.ToList());
        }

        //
        // GET: /Veterinario/Details/5

        public ActionResult Details(int id = 0)
        {
            Clinica clinica = db.Clinicas.Find(id);
            if (clinica == null)
            {
                return HttpNotFound();
            }
            return View(clinica);
        }

        //
        // GET: /Veterinario/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Veterinario/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Clinica clinica)
        {
            if (ModelState.IsValid)
            {
                db.Clinicas.Add(clinica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clinica);
        }

        //
        // GET: /Veterinario/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Clinica clinica = db.Clinicas.Find(id);
            if (clinica == null)
            {
                return HttpNotFound();
            }
            return View(clinica);
        }

        //
        // POST: /Veterinario/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Clinica clinica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clinica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clinica);
        }

        //
        // GET: /Veterinario/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Clinica clinica = db.Clinicas.Find(id);
            if (clinica == null)
            {
                return HttpNotFound();
            }
            return View(clinica);
        }

        //
        // POST: /Veterinario/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Clinica veterinario = db.Clinicas.Find(id);
            db.Clinicas.Remove(veterinario);
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