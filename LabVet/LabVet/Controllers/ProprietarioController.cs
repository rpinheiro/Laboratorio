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
    public class ProprietarioController : Controller
    {
        private PessoaDB db = new PessoaDB();

        //
        // GET: /Proprietario/

        public ActionResult Index()
        {
            return View(db.Proprietarios.ToList());
        }

        //
        // GET: /Proprietario/Details/5

        public ActionResult Details(int id = 0)
        {
            Proprietario proprietario = db.Proprietarios.Find(id);
            if (proprietario == null)
            {
                return HttpNotFound();
            }
            return View(proprietario);
        }

        //
        // GET: /Proprietario/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Proprietario/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Proprietario proprietario)
        {
            if (ModelState.IsValid)
            {
                db.Proprietarios.Add(proprietario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(proprietario);
        }

        //
        // GET: /Proprietario/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Proprietario proprietario = db.Proprietarios.Find(id);
            if (proprietario == null)
            {
                return HttpNotFound();
            }
            return View(proprietario);
        }

        //
        // POST: /Proprietario/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Proprietario proprietario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proprietario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(proprietario);
        }

        //
        // GET: /Proprietario/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Proprietario proprietario = db.Proprietarios.Find(id);
            if (proprietario == null)
            {
                return HttpNotFound();
            }
            return View(proprietario);
        }

        //
        // POST: /Proprietario/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Proprietario proprietario = db.Proprietarios.Find(id);
            db.Pessoas.Remove(proprietario);
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