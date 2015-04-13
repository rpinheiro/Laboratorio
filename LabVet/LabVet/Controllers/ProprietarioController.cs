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
        private ProprietarioDB db = new ProprietarioDB();
        private ProprietarioTelefoneDB db2 = new ProprietarioTelefoneDB();

        //
        // GET: /Proprietario/

        public ActionResult Index()
        {
            return View(db2.Proprietarios.ToList());
        }

        //
        // GET: /Proprietario/Details/5

        public ActionResult Details(int id = 0)
        {
            Proprietario proprietario = db2.Proprietarios.Find(id);
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
                proprietario.Telefones.ToList().RemoveAll(t => t.NumeroTelefone == "");
                db2.Proprietarios.Add(proprietario);
                db2.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(proprietario);
        }

        //
        // GET: /Proprietario/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Proprietario proprietario = db2.Proprietarios.Find(id);
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
                db2.Entry(proprietario).State = EntityState.Modified;
                db2.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(proprietario);
        }

        //
        // GET: /Proprietario/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Proprietario proprietario = db2.Proprietarios.Find(id);
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
            Proprietario proprietario = db2.Proprietarios.Find(id);
            db2.Proprietarios.Remove(proprietario);
            db2.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db2.Dispose();
            base.Dispose(disposing);
        }
    }
}