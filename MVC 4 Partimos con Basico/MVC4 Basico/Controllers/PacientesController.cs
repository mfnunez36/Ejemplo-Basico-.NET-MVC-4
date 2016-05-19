using MVC4_Basico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4_Basico.Controllers
{
    public class PacientesController : Controller
    {
        //
        // GET: /Pacientes/


        ClinicaContext _db = new ClinicaContext();

        public ActionResult Index()
        {
            var pacientes = _db.Pacientes.ToList();

            return View(pacientes);
        }

        public ActionResult Nuevo()
        {
            return View();
        }

        public ActionResult Fonasa()
        {
            return View();
        }

        public ActionResult Isapre()
        {
            return View();
        }

        public ActionResult Ver(int ID)
        {
            Paciente pa = _db.Pacientes.Find(ID);
            return View(pa);
        }

        public ActionResult Editar(int ID)
        {
            ViewBag.id = ID;
            return View();
        }


        public ActionResult Enfermedades_Paciente(int ID)
        {
            ViewBag.id = ID;
            return View();
        }

    }
}
