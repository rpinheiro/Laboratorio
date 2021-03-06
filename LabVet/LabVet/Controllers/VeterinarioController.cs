﻿using System;
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
    public class VeterinarioController : Controller
    {
        private PessoaDB db = new PessoaDB();

        //
        // GET: /Veterinario/

        public ActionResult Index()
        {
            return View(db.Pessoas.OfType<Veterinario>().ToList());
        }

        //
        // GET: /Veterinario/Details/5

        public ActionResult Details(int id = 0)
        {
            Veterinario veterinario = (Veterinario)db.Pessoas.Find(id);
            if (veterinario == null)
            {
                return HttpNotFound();
            }
            return View(veterinario);
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
        public ActionResult Create(Veterinario veterinario)
        {
            if (ModelState.IsValid)
            {
                db.Pessoas.Add(veterinario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(veterinario);
        }

        //
        // GET: /Veterinario/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Veterinario veterinario = (Veterinario)db.Pessoas.Find(id);
            if (veterinario == null)
            {
                return HttpNotFound();
            }
            return View(veterinario);
        }

        //
        // POST: /Veterinario/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Veterinario veterinario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(veterinario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(veterinario);
        }

        //
        // GET: /Veterinario/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Veterinario veterinario = (Veterinario)db.Pessoas.Find(id);
            if (veterinario == null)
            {
                return HttpNotFound();
            }
            return View(veterinario);
        }

        //
        // POST: /Veterinario/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Veterinario veterinario = (Veterinario)db.Pessoas.Find(id);
            db.Pessoas.Remove(veterinario);
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