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
            ProprietarioDB dbPessoa = new ProprietarioDB();
            //dbPessoa.Pessoas.Add(new Proprietario() { Nome = "Rafael de Araújo" });
            //dbPessoa.Pessoas.Add(new Proprietario() { Nome = "Julia" });
            //dbPessoa.Pessoas.Add(new Proprietario() { Nome = "Mariana" });
            //dbPessoa.SaveChanges();

            IList<Proprietario> listaDePessoas = dbPessoa.Proprietarios.ToList();
            
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
