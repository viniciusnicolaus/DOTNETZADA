using Fiap03.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap03.Web.MVC.Controllers
{
    public class TimeController : Controller
    {
        //Simular o banco de daos (memória) - sempre que o atribuo for privado colocar_
        private static List<Time> _lista = new List<Time>();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_lista);
        }
        [HttpGet]
        public ActionResult Cadastrar()
        {
            //Criar a lista com as opções da liga
            var lista = new List<string>();
            lista.Add("Global");
            lista.Add("Regional");
            lista.Add("Estadual");

            //Enviar a lista de opções para a tela
            ViewBag.listaLiga = new SelectList(lista);


            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Time time)
        {
            //Mensagem de sucesso
            TempData["msg"] = "Time registrado! Boa sorte!";
            _lista.Add(time);
            //Redirect para não cadastrar vários no F5
            return RedirectToAction("Cadastrar");
        }
    }
}