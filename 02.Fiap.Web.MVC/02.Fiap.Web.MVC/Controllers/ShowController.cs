using _02.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02.Fiap.Web.MVC.Controllers
{
    public class ShowController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost] // Recupera as informações do formulário
        public ActionResult Cadastrar(Show show)
        {
            // Enviar valores para a página
            ViewBag.churros = show.Banda;
            TempData["msg"] = "Show cadastrado";
            return View(show);
            //return Content(show.Banda); //retorna um texto
        }

    }
}