using Fiap._04.Web.MVC.Models;
using Fiap._04.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap._04.Web.MVC.Controllers
{
    public class PessoaController : Controller
    {
        private ImigracaoContext _context = new ImigracaoContext(); 
        
        [HttpPost]
        public ActionResult Remover(int id)
        {
            var pessoa = _context.Pessoas.Find(id);
            _context.Pessoas.Remove(pessoa);
            _context.SaveChanges();
            TempData["msg"] = "Pessoa removida com sucesso";
            return RedirectToAction("Listar");

        }


        [HttpPost]
        public ActionResult Alterar(Pessoa pessoa)
        {
            _context.Entry(pessoa).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Pessoa atualizada!";
            return RedirectToAction("Listar");
        }


        [HttpGet]
        public ActionResult Alterar(int id)
        {
            var pessoa = _context.Pessoas.Find(id);
            return View(pessoa);
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var lista = _context.Pessoas.ToList();
            return View(lista);
        }


        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado";
            return RedirectToAction("Cadastrar");
        }
    }
}

