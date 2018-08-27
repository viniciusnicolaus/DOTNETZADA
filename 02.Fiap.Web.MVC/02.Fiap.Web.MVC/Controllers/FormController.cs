using _02.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02.Fiap.Web.MVC.Controllers
{
    public class FormController : Controller
    {
       [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Formulario(Form form)
        {
            ViewBag.churros = form.Nome;
            TempData["msg"] = "Formulário cadastrado com sucesso";
            return View("Formulario");
        }
    }
}