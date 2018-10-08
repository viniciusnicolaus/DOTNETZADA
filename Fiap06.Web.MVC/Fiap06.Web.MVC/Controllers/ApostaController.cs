﻿using Fiap06.Web.MVC.Models;
using Fiap06.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap06.Web.MVC.Controllers
{
    public class ApostaController : Controller
    {
        UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            CarregarSelectConcurso();
            return View();
        }

        public ActionResult Listar()
        {
            var lista = _unit.ApostaRepository.Listar();
            return View(lista);
        }

        private void CarregarSelectConcurso()
        {
            var dropLista = _unit.ConcursoRepository.Listar();
            ViewBag.concursos = new SelectList(dropLista, "Numero", "Numero");
        }

        [HttpPost]
        public ActionResult Cadastrar(Aposta aposta)
        {
            _unit.ApostaRepository.Cadastrar(aposta);
            _unit.Salvar();
            TempData["msg"] = "Aposta cadastrada com sucesso";

            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}