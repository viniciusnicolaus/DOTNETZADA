using Execicio.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Execicio.Web.MVC.Controllers
{
    public class RefeicaoController : Controller { 

   
         private static List<Refeicao> _lista = new List<Refeicao>();

        [HttpGet]
        public ActionResult Listar()
        {
        return View(_lista);
        }
        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = new List<String>();
            lista.Add("Suco");
            lista.Add("Refrigerante");
            lista.Add("Leite com manga");

            ViewBag.listaBebida = new SelectList(lista);

            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Refeicao refeicao)
        {
            TempData["msg"] = "Refeição cadastrada com sucesso! Boa refeição!";
            _lista.Add(refeicao);
            //Redirect para não cadastrar vários no F5
            return RedirectToAction("Cadastrar");
            
        }
    }
}