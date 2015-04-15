using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LabVet.Models.DBContext;
using LabVet.Models;
using System.Data.Entity.Validation;
using System.Diagnostics; 

namespace LabVet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ClinicaDB db = new ClinicaDB();
            //Veterinario v = new Veterinario() { nome = "teste", Crmv="123"};
            //IList<Veterinario> listaV = new List<Veterinario>();
            //listaV.Add(v);

            //db.Clinicas.Add(new Clinica() { nome= "clinicao", Veterinarios = listaV});
            //db.SaveChanges();
            //var lista = db.Clinicas.ToList();
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
