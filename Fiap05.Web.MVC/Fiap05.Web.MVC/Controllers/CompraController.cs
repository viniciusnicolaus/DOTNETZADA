﻿using Fiap05.Web.MVC.Models;
using Fiap05.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap05.Web.MVC.Controllers
{
    public class CompraController : Controller
    {
        private FiapBankContext _context = new FiapBankContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _context.CartoesVirtuais.ToList().Where(c => c.Utilizado == false);
            ViewBag.listaCv = new SelectList(lista, "CartaoVirtualId", "Numero");

            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Compra compra)
        {
            _context.Compras.Add(compra);
            _context.SaveChanges();
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var lista = _context.Compras.Include("CartaoVirtual").ToList();
            return View(lista);
        }
    }
}