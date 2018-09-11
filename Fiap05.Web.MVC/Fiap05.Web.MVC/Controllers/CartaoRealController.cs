﻿using Fiap05.Web.MVC.Models;
using Fiap05.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap05.Web.MVC.Controllers
{
    public class CartaoRealController : Controller
    {

        private FiapBankContext _context = new FiapBankContext();
         
    [HttpGet]
    public ActionResult AprovarCartao(int id)
    {
            var cartoes =_context.CartoesReais.Find(id);
            return View(cartoes);
    }

    [HttpPost]
    public ActionResult AprovarCartao(CartaoReal cartoes)
    {
            
            return View("Listar");
    }


    [HttpGet]
    public ActionResult Listar()
    {
        var lista = _context.CartoesReais.ToList();
        return View(lista);
    }


    [HttpGet]
    public ActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Cadastrar(CartaoReal cr)
    {
        _context.CartoesReais.Add(cr);
        _context.SaveChanges();
        TempData["msg"] = "Cadastrado";
        return RedirectToAction("Cadastrar");
    }

    }
}