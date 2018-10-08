using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap07.Web.MVC.Controllers
{
    public class FilmeController : Controller
    {
        UnitOfWork _unit = new UnitOfWork();

        [HttpPost]
        public ActionResult Cadastrar(Filme filme)
        {
            _unit.FilmeRepository.Cadastrar(filme);
            _unit.Salvar();
            TempData["msg"] = "Filme cadastrado com sucesso";

            return RedirectToAction("Cadastrar");
        }


        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
    }
}