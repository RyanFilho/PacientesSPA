using PacientesSPA.Data_Acess_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PacientesSPA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PacienteManager manager = new PacienteManager();
            return View(manager.Get());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}