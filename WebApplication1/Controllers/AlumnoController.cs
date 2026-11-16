using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AlumnoController : Controller
    {
        static List<Alumno> listaAlumnos = new List<Alumno>()
        {
            new Alumno(1001, "Oliver Sonne", 450.90, DateTime.Parse("30/06/2002")),
            new Alumno(1002, "André Carrillo", 380.50, DateTime.Parse("10/05/2000"))        };

        // GET:
        public ActionResult Inicio()
        {
            return View();
        }
        public ActionResult Index()

        {
            return View(listaAlumnos);
        }
    }
}