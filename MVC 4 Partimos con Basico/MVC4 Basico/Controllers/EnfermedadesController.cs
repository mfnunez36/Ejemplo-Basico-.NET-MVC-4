using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4_Basico.Controllers
{
    public class EnfermedadesController : Controller
    {
        //
        // GET: /Enfermedades/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Nueva()
        {
            return View();
        }

        public ActionResult Auge()
        {
            return View();
        }


        public ActionResult NoAuge()
        {
            return View();
        }

        public ActionResult Ver(int ID)
        {
            ViewBag.id = ID;
            return View();
        }

        public ActionResult Editar(int ID)
        {
            ViewBag.id = ID;
            return View();
        }

    }
}
