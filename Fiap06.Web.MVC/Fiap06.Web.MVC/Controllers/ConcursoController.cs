using Fiap06.Web.MVC.Models;
using Fiap06.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap06.Web.MVC.Controllers
{
    public class ConcursoController : Controller
    {
        UnitOfWork _unit = new UnitOfWork();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var lista = _unit.ConcursoRepository.Listar();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Concurso concurso)
        {
            _unit.ConcursoRepository.Cadastrar(concurso);
            _unit.Salvar();
            TempData["msg"] = "Concurso registrado!";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}