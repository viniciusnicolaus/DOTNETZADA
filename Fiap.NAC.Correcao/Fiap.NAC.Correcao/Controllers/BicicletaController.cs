using Fiap.NAC.Correcao.Models;
using Fiap.NAC.Correcao.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.NAC.Correcao.Controllers
{
    public class BicicletaController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _unit.CategoriaRepository.Listar();
            ViewBag.categorias = new SelectList(lista, "CategoriaId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Bicicleta bicicleta)
        {
            _unit.BicicletaRepository.Cadastrar(bicicleta);
            _unit.Salvar();
            TempData["msg"] = "Cadastrada com sucesso";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_unit.BicicletaRepository.Listar());
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}