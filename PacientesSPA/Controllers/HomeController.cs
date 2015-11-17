using PacientesSPA.Data_Acess_Layer;
using PacientesSPA.ViewModels;
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
            PacienteVM viewModel = new PacienteVM();

            viewModel.HandleRequest();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(PacienteVM viewModel)
        {
            viewModel.IsValid = ModelState.IsValid;
            viewModel.HandleRequest();

            if (viewModel.IsValid)
            {
                ModelState.Clear();
            }
            else
            {
                foreach(KeyValuePair<string, string> item in viewModel.ValidationErros)
                {
                    ModelState.AddModelError(item.Key, item.Value);
                }
            }            

            return View(viewModel);
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