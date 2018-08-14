using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace _02.Fiap.Web.MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string senha)
        {
           if(username == "FIAP" && senha == "FIAP123")
            {
                ViewBag.Login = username;
                TempData["msgSucesso"] = "Sucesso ao logar";
                return View();
            }
            else
            {
                TempData["msgErro"] = "Erro ao logar";
                return View("Index");   
            }
              
        }
    }
}